using UnityEngine;
using System.Collections;
//生成されたら放物運動していい感じに飛ばす
//敵に触れたらアクションを起こす
public class RockBuster : MonoBehaviour {
    public float MassX, MassY;

    // Use this for initialization
    void Start () {
    
        //平面の物理演算系
        GetComponent<Rigidbody2D>().velocity = new Vector2(MassX, MassY);
        //オブジェクトを破壊する(自分)
        Destroy(this.gameObject, 5f);
    }
	//接触判定
	void OnTriggerEnter2D(Collider2D col)
    {
        //タグがenemyだったら弾と敵を削除する
        if(col.gameObject.tag == "enemy")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
        //フィールドオブジェクトに当たったら弾を消す
        else if(col.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
    //自分が破壊された時
    void OnDestroy()
    {
        //制限緩和
        shot.countRockBuster -= 1;
    }
}
