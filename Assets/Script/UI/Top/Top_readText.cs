using UnityEngine;
using System.Collections;

public class Top_readText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void closeText()
    {
        GameObject.Find("readText").GetComponent<Canvas>().enabled = false;
    } 
}
