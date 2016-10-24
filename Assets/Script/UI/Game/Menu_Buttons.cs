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
        GameObject.Find("Reset_Conf").GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Number_Manager.Lives < 0)
        {
            Time.timeScale = 0;
            Reset_Conf();
        }
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

    public void Reset_Conf()
    {
        GameObject.Find("Reset_Conf").GetComponent<Canvas>().enabled = true;
        GameObject.Find("playMenu").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Start_Image").GetComponent<Canvas>().enabled = false;
    }

    public void Continue_Button()
    {
        Time.timeScale = 1;
        GameObject.Find("playMenu").GetComponent<Canvas>().enabled = false;
        GameObject.Find("Reset_Conf").GetComponent<Canvas>().enabled = false;
        GameObject.Find("playButton").GetComponent<Canvas>().enabled = true;
    }

    public void Reset_OK()
    {
        SceneManager.LoadScene("Top");
    }

    public void Reset_NG()
    {
        if (Number_Manager.Lives < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Number_Manager.Score = 0;
            Number_Manager.Lives = 5;
        }
        else {
            Continue_Button();
        }
        GameObject.Find("Reset_Conf").GetComponent<Canvas>().enabled = false;
    }
}
