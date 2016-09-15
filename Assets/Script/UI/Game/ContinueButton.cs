using UnityEngine;
using System.Collections;

public class ContinueButton : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void continue_button()
    {
        Time.timeScale = 1;
        GameObject.Find("playMenu").GetComponent<Canvas>().enabled = false;
        GameObject.Find("playButton").GetComponent<Canvas>().enabled = true;
    }
}
