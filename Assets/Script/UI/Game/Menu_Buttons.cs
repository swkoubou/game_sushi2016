using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    public int score = 0;
    public bool stop = false;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0;
        GameObject.Find("Player").GetComponent<Player>().enabled = false;
        GameObject.Find("playButton").GetComponent<Canvas>().enabled = false;
        GameObject.Find("playMenu").GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("playButton/ScoreView").GetComponent<Text>().text = "Score:" + Player.Score.ToString();
    }

    public void Start_Button()
    {
        GameObject.Find("Start_Image").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Player").GetComponent<Player>().enabled = true;
        GameObject.Find("playButton").GetComponent<Canvas>().enabled = true;
        Time.timeScale = 1;
    }

    public void Stop_Button()
    {
        Time.timeScale = 0;
        GameObject.Find("playButton").GetComponent<Canvas>().enabled = false;
        GameObject.Find("playMenu").GetComponent<Canvas>().enabled = true;
        stop = true;
    }

    public void Move_Top()
    {
        SceneManager.LoadScene("Top");
    }

    public void Continue_Button()
    {
        Time.timeScale = 1;
        GameObject.Find("playMenu").GetComponent<Canvas>().enabled = false;
        GameObject.Find("playButton").GetComponent<Canvas>().enabled = true;
    }
}
