using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class startgame : MonoBehaviour {

	
	void Start () {
        Time.timeScale = 0;
        GameObject.Find("Player").GetComponent<Player>().enabled = false;
        GameObject.Find("playButton").GetComponent<Canvas>().enabled = false;
    }
	public void startgames()
    {
        GameObject.Find("Start_Image").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Player").GetComponent<Player>().enabled = true;
        GameObject.Find("playButton").GetComponent<Canvas>().enabled = true;
        Time.timeScale = 1;
    }

}
