using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript_1 : MonoBehaviour {

    public float bulletFireSpeed;


	// Use this for initialization
	void Start () {

        //5秒钟之后销毁
        Destroy(this.gameObject, 5);
    }
	
	// Update is called once per frame
	void Update () {

        //向Z轴正方向移动，乘以Time.deltaTime是为了矫正非匀速刷新情况下的速度位移偏差
        this.transform.Translate(new Vector3(0,0, bulletFireSpeed*Time.deltaTime),Space.Self);
	}
}
