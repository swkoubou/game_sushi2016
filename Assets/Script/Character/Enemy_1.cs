using UnityEngine;
using System.Collections;
//上下or左右反復運動　選べるようにする
//細かく設定できるように
//移動系統のみ実装
public class Enemy_1 : MonoBehaviour {
    private Vector3 startPos;
    //移動スピード
    public float speed = 5f;
    //移動範囲
    public float moveRange = 10f;
    //モードを選べるようにする
    public EnemyMove enemymode;
    public enum EnemyMove
    {
        Kuribo, PataPata,
    }
	void Start () {
        //初めに自分の位置を取得する
        startPos = transform.position;
	}
	
	void Update () {
        //0からmoveRangeまで往復値を格納
        var pingpong = Mathf.PingPong(Time.time * speed, moveRange);
        //くりぼーもーどの時
        if (enemymode == EnemyMove.Kuribo)
        {
           transform.position=new Vector2(startPos.x-pingpong,transform.position.y);
        }
        //バタパタモードの時
        else if (enemymode == EnemyMove.PataPata)
        {
            transform.position=new Vector2(startPos.x,startPos.y+pingpong);
        }
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Attack")
        {
            Player.Score += 100;
            Destroy(this.gameObject);
        }
    }
}
