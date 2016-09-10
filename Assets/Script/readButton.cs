using UnityEngine;
using System.Collections;

public class readButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("readtxt").GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	public void poptxt () {
        GameObject.Find("readtxt").GetComponent<readButton>().enabled = true;
    }
}
