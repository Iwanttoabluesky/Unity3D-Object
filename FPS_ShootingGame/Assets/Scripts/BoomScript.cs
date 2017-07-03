using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomScript : MonoBehaviour {

    //爆炸用球体
    public GameObject BoomCube;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "PlayerBullet") {

            Debug.Log("爆炸");
            BoomCube.SetActive(true);
            Destroy(this.gameObject, 0.3f);

        }

    }
}
