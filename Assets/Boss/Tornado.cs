using UnityEngine;
using System.Collections;

public class Tornado : MonoBehaviour {
    //private Vector2 startPos;
    private float timer;
 
	// Use this for initialization
	void Start () {
        //startPos = transform.position;
	}

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        transform.Translate(new Vector2(-10f * Time.deltaTime, 0f));
        if (timer == 10)
        {
            Destroy(this.gameObject);
        }
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Attack")
        {
            Destroy(this.gameObject);
        }
    }
}
