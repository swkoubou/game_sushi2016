using UnityEngine;
using System.Collections;

public class CameraTrace : MonoBehaviour {
    private GameObject player;
    private Vector3 newPoS;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        transform.Translate(new Vector2(Player.Lastpos,0f));
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 targetCamPoS = player.transform.position + offset;
        if (transform.position.x < targetCamPoS.x&& Number_Manager.CamMove_On == true)
        {
            transform.position = Vector3.Lerp(transform.position,
                new Vector3(targetCamPoS.x, transform.position.y, transform.position.z),
                10 * Time.deltaTime);
        }
	}
}
