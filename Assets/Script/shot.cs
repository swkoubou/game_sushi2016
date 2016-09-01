using UnityEngine;
using System.Collections;
//プレイヤーにつけて任意のボタンを押したらバスター攻撃
//バスター攻撃は三回制限
//敵に当たったら弾も、敵も消す
//地面に当たったら弾を消す=制限緩和する
public class shot : MonoBehaviour {
    //static=いい感じに他から値にアクセスできる感じ
    static public int countRockBuster = 0;

    //発射するやつ本体
    public GameObject buster;

    //アプリケーション実行時に一回は呼ばれるやつ
    //mainみたいなやつ
	void Start () {
        countRockBuster = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (countRockBuster < 3 && Input.GetKeyDown(KeyCode.Z))
        {
            //いい感じに生み出す？　何を生む？どこに産む？角度？
            Instantiate(buster, new Vector2(transform.position.x + 5f, transform.position.y + 5f)
                , Quaternion.identity);
            countRockBuster += 1;
        }
	}
}
