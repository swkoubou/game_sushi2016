using UnityEngine;
using System.Collections;
//プレイヤーにつけて任意のボタンを押したらバスター攻撃
//バスター攻撃は三回制限
//敵に当たったら弾も、敵も消す
//地面に当たったら弾を消す=制限緩和する
public class shot : MonoBehaviour
{
    //static=いい感じに他から値にアクセスできる感じ
    static public int countRockBuster = 0;
    static bool Rmuki;

    //発射するやつ本体
    public GameObject buster;
    public GameObject buster2;

    //アプリケーション実行時に一回は呼ばれるやつ
    //mainみたいなやつ
	void Start () {
        countRockBuster = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (countRockBuster < 3 && Input.GetKeyDown(KeyCode.Z))
        {

            if (Rmuki ==true)
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
            
            countRockBuster += 1;
        }
	}
}
