using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class readButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("readtxt").GetComponent<Button>().enabled = false;
    }
	
	// Update is called once per frame
	public void poptxt () {
        GameObject.Find("readtxt").GetComponent<Button>().enabled = true;
    }
}
