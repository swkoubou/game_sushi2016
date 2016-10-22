using UnityEngine;
using System.Collections;

public class Checkpoint_Script : MonoBehaviour
{
    SpriteRenderer CheckG;
    public Sprite OFF;
    public Sprite ON;
    // Use this for initialization
    void Start()
    {
        CheckG = gameObject.GetComponent<SpriteRenderer>();
        CheckG.sprite = OFF;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Player.Lastpos = transform.position.x-9;
            CheckG.sprite = ON;

        }
    }
}
