using UnityEngine;
using System.Collections;

public class Enemy_2 : MonoBehaviour
{
    SpriteRenderer SpriteR;
    public Sprite Waits;
    public Sprite Fire;
    public GameObject Shot;
    bool ShotFinish = false;
    public float ShotRange;
    // Use this for initialization
    void Start()
    {
        SpriteR = gameObject.GetComponent<SpriteRenderer>();
        SpriteR.sprite = Waits;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - GameObject.Find("Player").transform.position.x < ShotRange && ShotFinish == false)
        {
            Instantiate(Shot, new Vector2(transform.position.x - 10f, transform.position.y + 1f)
                , Quaternion.identity);
            SpriteR.sprite = Fire;
            ShotFinish = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Attack")
        {
            Number_Manager.Score += 100;
            Destroy(this.gameObject);
        }
    }
}
