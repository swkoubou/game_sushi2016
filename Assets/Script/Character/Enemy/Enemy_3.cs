using UnityEngine;
using System.Collections;

public class Enemy_3 : MonoBehaviour
{
    Vector3 startPos;
    float findPlayer = 0;
    public float Range = 0;
    public float Fall_Spead = 9.8f;
    public float Side_Speed = 0f;
    public Enemy_Mode enemymode;
    public enum Enemy_Mode { Para, Str, }
    public bool Cam_On = false;

    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        findPlayer = transform.position.x - GameObject.Find("Player").transform.position.x;
        if (Time.timeScale == 1 && Cam_On == true)
        {
            if (findPlayer < Range)
            {
                if (enemymode == Enemy_Mode.Str)
                {
                    transform.Translate(new Vector2(-Side_Speed, -Fall_Spead));
                }
                if (enemymode == Enemy_Mode.Para)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(-Fall_Spead, -Side_Speed);
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Attack")
        {
            Number_Manager.Score += 100;
            Destroy(this.gameObject);
        }
        if (col.tag == "MainCamera")
        {
            Cam_On = true;
        }
    }
}
