using UnityEngine;
using System.Collections;

public class Player_Shot : MonoBehaviour
{
    public float MassX, MassY;
    private Animator anime;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(MassX, MassY);
        Destroy(this.gameObject, 5f);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(this.gameObject);
    }
}
