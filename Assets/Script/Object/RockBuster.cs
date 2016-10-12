using UnityEngine;
using System.Collections;
//生成されたら放物運動していい感じに飛ばす
//敵に触れたらアクションを起こす
public class RockBuster : MonoBehaviour
{
    public float MassX, MassY;
    private Animator anime;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(MassX, MassY);
        Destroy(this.gameObject, 5f);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(this.gameObject);
    }
}
