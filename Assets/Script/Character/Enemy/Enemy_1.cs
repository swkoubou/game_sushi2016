using UnityEngine;
using System.Collections;
//上下or左右反復運動　選べるようにする
//細かく設定できるように
//移動系統のみ実装
public class Enemy_1 : MonoBehaviour
{
    private Vector3 startPos;
    //移動スピード
    public float speed = 5f;
    //移動範囲
    public float moveRange = 10f;
    //モードを選べるようにする
    public EnemyMove enemymode;
    public enum EnemyMove
    {
        UpDown, LeftRight, Left, Up,
    }
    void Start()
    {
        //初めに自分の位置を取得する
        startPos = transform.position;
    }

    void Update()
    {
        //0からmoveRangeまで往復値を格納
        if (Time.timeScale == 1)
        {
            var pingpong = Mathf.PingPong(Time.time * speed, moveRange);
            if (enemymode == EnemyMove.UpDown)
            {
                transform.position = new Vector2(startPos.x, startPos.y + pingpong);
            }
            else if (enemymode == EnemyMove.LeftRight)
            {
                transform.position = new Vector2(startPos.x - pingpong, transform.position.y);
            }
            else if (enemymode == EnemyMove.Up)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + (speed / 32));
            }
            else if (enemymode == EnemyMove.Left)
            {
                transform.position = new Vector2(transform.position.x - (speed / 32), transform.position.y);
            }
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Attack")
        {
            Number_Manager.Score += 100;
            Destroy(this.gameObject);
        }
    }
}
