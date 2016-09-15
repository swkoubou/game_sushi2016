using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Top_startButton : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameStart()
    {
        RockBuster.enScore = 0;
        SceneManager.LoadScene("stage01");
    }
}
