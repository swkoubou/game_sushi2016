using UnityEngine;
using System.Collections;

public class Enemy_Boss1 : MonoBehaviour
{

    public int Boss_HP = 0;
    public float Suikomi_Range = 0f;
    public GameObject Boss_Shot;
    public float shot_long = 0;
    bool Cam_On = false;
    float Player_Distance = 100;

    GameObject Player;


    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("Player");
        StartCoroutine(ArrowShot());
    }

    // Update is called once per frame
    void Update()
    {
        Player_Distance = transform.position.x - Player.transform.position.x;
        Suikomi();
        if (Boss_HP <= 0)
        {
            Number_Manager.Score += 1200;
            Destroy(this.gameObject);
            Number_Manager.CamMove_On = true;
        }
    }

    void Suikomi()
    {
        if (Player_Distance <= Suikomi_Range)
        {
            Player.transform.Translate(new Vector2(0.1f, 0f));
        }
    }

    IEnumerator ArrowShot()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Debug.Log("Shot!");
            if (Cam_On == true)
            {
                Debug.Log("Shot!");
                Instantiate(Boss_Shot, new Vector2(transform.position.x - shot_long, Player.transform.position.y+8f)
                            , Quaternion.identity);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Attack")
        {
            Debug.Log(Boss_HP);
            Boss_HP -= 100;
        }
        if (col.tag == "MainCamera")
        {
            Cam_On = true;
        }
    }
}
