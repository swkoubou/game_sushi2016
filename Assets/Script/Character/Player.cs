using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float moveValue = 15f;//移動量.
    public float jumppower = 5f;
    public SpriteRenderer render;
    public Sprite jumpImage, walkImage;
    public bool Rmuki = true;
    static public int countRockBuster = 0;

    private bool isGround;
    private Animator anime;
    public GameObject buster;
    public GameObject buster2;
    void Start()
    {
        //あらかじめSpriteRenderを取得する
        render = GetComponent<SpriteRenderer>();
        isGround = false;
        anime = GetComponent<Animator>();
        anime.enabled = true;
        isGround = false;
        countRockBuster = 0;
    }


    void Update()
    {
        //→が押されたらYES　それ以外はNO.
        //animator.SetBool("tap", false);
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
            if (isGround)
            {
                //render.sprite = walkImage;
            }
            render.sprite = jumpImage;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {

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
            //いい感じに生み出す？　何を生む？どこに産む？角度？

            //countRockBuster += 1;
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
}
