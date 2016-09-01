using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class startgame : MonoBehaviour {

	
	void Start () {
        Time.timeScale = 0;
        GameObject.Find("Player").GetComponent<Player>().enabled = false;
	}
	public void startgames()
    {
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Player").GetComponent<Player>().enabled = true;
        Time.timeScale = 1;
    }

}
