using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_02 : MonoBehaviour {

    public GameObject BoomObj;

    //当碰撞效果发生的时候执行一次
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("检测到了碰撞:"+collision.gameObject.name);

        if (collision.gameObject.name == "PlayerBullet") {

            //激活爆炸球体
            BoomObj.SetActive(true);
        }

    }



}
