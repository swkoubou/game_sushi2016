using UnityEngine;
using System.Collections;

public class CamMove_Off : MonoBehaviour
{
    public float MoveRange = 0;
    public float MoveSpeed = 0;
    public bool MoveStart = false;
    Vector2 CamPos;
    GameObject Camera;
    // Use this for initialization
    void Start()
    {
        Camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if ((Camera.transform.position.x - CamPos.x <= MoveRange) && (MoveStart == true))
        {
            Camera.transform.Translate(new Vector2(MoveSpeed * Time.deltaTime, 0f));
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "MainCamera")
        {
            Number_Manager.CamMove_On = false;
            CamPos = Camera.transform.position;
            MoveStart = true;
        }
    }
}
