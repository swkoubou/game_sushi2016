using UnityEngine;
using System.Collections;

public class Checkpoint_Script : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Player.Lastpos = transform.position.x;

        }
    }
}
