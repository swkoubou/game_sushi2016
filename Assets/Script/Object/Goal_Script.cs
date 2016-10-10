using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal_Script : MonoBehaviour
{

    public AudioClip audioClip;
    AudioSource audioSource;
    public bool last = false;

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
        if (col.tag == "Player")
        {
            audioSource.PlayOneShot(audioClip);
            yield return new WaitForSeconds(1);
            Player.Lastpos = 0;
            if (last == true)
            {
                SceneManager.LoadScene("End");
            }
            else
            {
                Number_Manager.Stage++;
                SceneManager.LoadScene("Stage_" + Number_Manager.Stage.ToString());

            }
        }
    }
}
