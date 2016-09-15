using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReatartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void MoveTop()
    {
        SceneManager.LoadScene("Top");
    }
}
