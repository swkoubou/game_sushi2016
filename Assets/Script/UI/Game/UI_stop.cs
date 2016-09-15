using UnityEngine;
using System.Collections;

public class UI_stop : MonoBehaviour
{
    public bool stop = false;
    // Use this for initialization
    void Start()
    {
        GameObject.Find("playMenu").GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void click_stop()
    {
        Time.timeScale = 0;
        GameObject.Find("playButton").GetComponent<Canvas>().enabled = false;
        GameObject.Find("playMenu").GetComponent<Canvas>().enabled = true;
        stop = true;
    }
}
