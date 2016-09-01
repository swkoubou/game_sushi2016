using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float moveValue = 15f;//移動量.
    public float jumppower = 5f;
    public SpriteRenderer render;
    public Sprite jumpImage, walkImage;

    private bool isGround;
    private Animator anime;
    void Start()
    {
        //あらかじめSpriteRenderを取得する
        render = GetComponent<SpriteRenderer>();
        isGround = false;
        anime = GetComponent<Animator>();
        anime.enabled = true;
        isGround = false;
    }


    void Update()
    {
        //→が押されたらYES　それ以外はNO.
        //animator.SetBool("tap", false);
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
            if (isGround == true)
            {
                //anime.enabled = true;
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //                   new Vector2(       x,                   y).
            transform.Translate(new Vector2(-moveValue * Time.deltaTime, 0f));
            anime.SetBool("tap", true);
            anime.SetBool("right", false);
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
            if (isGround)
            {
                //render.sprite = walkImage;
            }
            render.sprite = jumpImage;
        }
    }
    //こいつに触れた情報がcolになる
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Ground" || col.tag == "Object")
        {
            isGround = true;
            //render.sprite = walkImage;
        }
        {
            isGround = true;
            //render.sprite = walkImage;
        }
        if (col.tag == "death" || col.tag == "enemy")
        {
            restart();
        }
        if (col.tag == "goal")
        {
            Invoke("restart", 3f);
            GetComponent<Player>().enabled = false;
            GetComponent<shot>().enabled = false;
            GetComponent<Animator>().enabled = false;
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
