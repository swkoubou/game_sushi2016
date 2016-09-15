using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal_Script : MonoBehaviour
{

    public AudioClip audioClip;
    AudioSource audioSource;
    bool click = false;
    public int Stage;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player" && click == false)
        {
            audioSource.PlayOneShot(audioClip);
            click = true;
            yield return new WaitForSeconds(1);
            restart();
            //SceneManager.LoadScene("Scene"+Stage);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
