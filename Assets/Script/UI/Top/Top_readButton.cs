using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Top_readButton : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject.Find("readText").GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pop_read()
    {
        GameObject.Find("readText").GetComponent<Canvas>().enabled = true;
    }
}
