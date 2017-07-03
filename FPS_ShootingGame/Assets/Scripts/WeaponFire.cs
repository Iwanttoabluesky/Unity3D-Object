using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour {

    public float fireSpeed;//开火速度
    public GameObject firePoint;//开火点
    public GameObject bulletObject;//子弹目标物

	void Update () {
        //点击鼠标开火
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Fire");
            InvokeRepeating("Fire", 0,1/fireSpeed);
        }
        //不点击鼠标不开火
        if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("Fire");
        }
    }

    void Fire() {
        //实例化一个子弹物体
        GameObject newBullet = Instantiate(bulletObject);
        //重命名
        newBullet.name = "PlayerBullet";
        //调整坐标与角度
        newBullet.transform.position = firePoint.transform.position;
        newBullet.transform.eulerAngles = firePoint.transform.eulerAngles;
    }
}
