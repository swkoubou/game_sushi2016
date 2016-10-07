using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float moveValue = 15f;//移動量.
    public float jumppower = 5f;
    public bool Rmuki = true;
    public bool JumpSet = true;
    public static int Score = 0;
    public static int Lives = 5;
    public static int Stage = 1;
    public static float Lastpos = 0;
    private bool isGround;
    private Animator anime;
    public GameObject buster;
    public GameObject buster2;
    void Start()
    {
        //あらかじめSpriteRenderを取得する
        isGround = false;
        anime = GetComponent<Animator>();
        anime.enabled = true;
        isGround = false;
        if (Lives == 0) Game_Over();
        transform.Translate(new Vector2(Lastpos, 2f));
    }


    void Update()
    {
        //→が押されたらYES　それ以外はNO.
        if (Input.GetKey(KeyCode.R))
        {
            restart();
        }
        if (isGround == true)
        {
            anime.enabled = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //                   new Vector2(       x,                   y).
            transform.Translate(new Vector2(moveValue * Time.deltaTime, 0f));
            anime.SetBool("tap", true);
            anime.SetBool("right", true);
            Rmuki = true;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //                   new Vector2(       x,                   y).
            transform.Translate(new Vector2(-moveValue * Time.deltaTime, 0f));
            anime.SetBool("tap", true);
            anime.SetBool("right", false);
            Rmuki = false;
        }
        //着地しているかつジャンプやりたい
        if (isGround && Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumppower * 100f));
            anime.enabled = false;
            isGround = false;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anime.SetBool("tap", false);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //いい感じに生み出す？　何を生む？どこに産む？角度？
            if (Rmuki == true)
            {
                Instantiate(buster, new Vector2(transform.position.x + 2f, transform.position.y + 3f)
                , Quaternion.identity);
            }
            else
            {
                Instantiate(buster2, new Vector2(transform.position.x - 2f, transform.position.y + 3f)
                , Quaternion.identity);
            }
        }
    }
    //こいつに触れた情報がcolになる
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Ground" || ((col.tag == "Object") && (JumpSet == true)))
        {
            isGround = true;
        }
        if (col.tag == "death" || col.tag == "enemy")
        {
            Score /= 2;
            Lives--;
            restart();
        }
        /*if (col.tag == "goal")
        {
            Invoke("restart", 3f);
            GetComponent<Player>().enabled = false;
            GetComponent<shot>().enabled = false;
            GetComponent<Animator>().enabled = false;
        }*/
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Game_Over()
    {

    }
}
