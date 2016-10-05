using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Top_Buttons : MonoBehaviour
{
    public string Stage_Name;
    // Use this for initialization
    void Start()
    {
        GameObject.Find("readText").GetComponent<Canvas>().enabled = false;

        Player.Score = 0;
        Player.Lives = 5;
        Player.Stage = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameStart()
    {
        Player.Score = 0;
        SceneManager.LoadScene(Stage_Name);
    }
    public void pop_read()
    {
        GameObject.Find("readText").GetComponent<Canvas>().enabled = true;
    }
    public void closeText()
    {
        GameObject.Find("readText").GetComponent<Canvas>().enabled = false;
    }
}
