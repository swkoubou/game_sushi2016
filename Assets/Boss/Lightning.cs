using UnityEngine;
using System.Collections;

public class Lightning : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //GetComponent<Animator>().SetTrigger("Lightning");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void destroy()
    {
        Destroy(this.gameObject);
    }
}
