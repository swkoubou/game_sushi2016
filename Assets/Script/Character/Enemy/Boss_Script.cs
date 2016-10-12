using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Boss_Script : MonoBehaviour
{

    private Vector3 startPos;
    //移動スピード
    public float upSpeed = 5f;
    public float leftSpeed = 5f;
    public float UpmoveRange = 10f;
    public float rightmoveRange = 10f;
    public float enemysa = 0;
    public float enemyinhale = 0;
    public Slider Boss_slider;
    public float BossHP = 0;
    float _hp = 0;
    bool hp_anim = true;
    public int BossScore;
    public float Start_distance;
    private Vector3 CamPos;

    void Start()
    {
        //初めに自分の位置を取得する
        startPos = transform.position;
        Boss_slider = GameObject.Find("playButton/Slider").GetComponent<Slider>();
        Boss_slider.gameObject.SetActive(false);
        Boss_slider.maxValue = BossHP;
    }

    void Update()
    {
        //横
        var updown = Mathf.PingPong(Time.time * upSpeed, UpmoveRange);
        var leftright = Mathf.PingPong(Time.time * leftSpeed, rightmoveRange);
        transform.position = new Vector2(startPos.x - leftright, startPos.y + updown);
        enemyinhale = transform.position.x - GameObject.Find("Player").transform.position.x;
        if (_hp < 0)
        {
            Number_Manager.Score += BossScore;
            Destroy(this.gameObject);
        }
        if (enemyinhale < Start_distance) CamIn();
        Playerinhale();
        Shot_if();
        Boss_slider.value = _hp;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Attack")
        {
            if (hp_anim == false) _hp -= 100;
        }
    }

    void Playerinhale()
    {
        if (enemyinhale < 32 && enemyinhale > -2)
        {
            GameObject.Find("Player").transform.Translate(new Vector2(0.1f, 0f));
        }
    }

    void Shot_if()
    {
        enemysa = transform.position.y - GameObject.Find("Player").transform.position.y;
        if (enemysa < 0.8 && enemysa > -0.8)
        {
            Debug.Log(enemysa);
        }
    }

    void CamIn()
    {
        CamPos = GameObject.Find("Main Camera").transform.position;
        GameObject.Find("Main Camera").transform.Translate(new Vector3(startPos.x+30, CamPos.y,CamPos.z));
        if (hp_anim)
        {
            Boss_slider.gameObject.SetActive(true);
            if (_hp >= Boss_slider.maxValue) hp_anim = false;
            _hp += 10;
        }
    }
}
