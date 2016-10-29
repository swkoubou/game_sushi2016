using UnityEngine;
using System.Collections;

public class Enemy_Shot : MonoBehaviour
{
    Vector3 eShot;
    public float Speed;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-Speed, +0f));
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != "MainCamera" && col.tag != "Player" && col.tag != "Attack")
        {
            Destroy(this.gameObject);
        }
    }
}
