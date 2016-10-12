using UnityEngine;
using System.Collections;

public class Enemy_Ball : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //タグがenemyだったら弾と敵を削除する
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        //フィールドオブジェクトに当たったら弾を消す
        else if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Object")
        {
            Destroy(this.gameObject);
        }
    }
}
