using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Endroll : MonoBehaviour
{
    Vector3 startPos;
    public int fallRange;
    public float fallSpeed;
    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<=fallRange)
        {
            transform.Translate(new Vector2(+0f,+fallSpeed));
        }
    }

    public void Go_Top()
    {
        SceneManager.LoadScene("Top");
    }
}
