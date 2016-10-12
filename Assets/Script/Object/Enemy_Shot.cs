using UnityEngine;
using System.Collections;

public class Enemy_Shot : MonoBehaviour
{

    // Use this for initialization
    public float MassX, MassY;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(MassX, MassY);
        //Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(GetComponent<Rigidbody2D>().velocity.normalized);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
