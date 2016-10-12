using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Top_Buttons : MonoBehaviour
{
    public int StartStage = 0;
    public int StartLives = 0;
    public int StartScore = 0;
    // Use this for initialization
    void Start()
    {
        GameObject.Find("readText").GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameStart()
    {
        Number_Manager.Score = StartScore;
        Number_Manager.Lives = StartLives;
        Number_Manager.Stage = StartStage;
        SceneManager.LoadScene("Stage_"+StartStage);
    }
    public void open_Text()
    {
        GameObject.Find("readText").GetComponent<Canvas>().enabled = true;
    }
    public void closeText()
    {
        GameObject.Find("readText").GetComponent<Canvas>().enabled = false;
    }
}
