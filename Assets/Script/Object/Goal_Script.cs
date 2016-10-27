using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal_Script : MonoBehaviour
{

    public AudioClip audioClip;
    AudioSource audioSource;
    SpriteRenderer Goal_G;
    public Sprite OFF;
    public Sprite ON;
    public bool last;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        Goal_G = gameObject.GetComponent<SpriteRenderer>();
        Goal_G.sprite = OFF;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Goal_G.sprite = ON;
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
