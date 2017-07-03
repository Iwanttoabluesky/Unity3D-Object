using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Script_01 : MonoBehaviour {

    //开火速度
    public float FireSpeed;

    //子弹数目
    public int BulletCount;

    //开火子弹
    public GameObject BulletPrefab;

    //开火点
    public GameObject FirePoint;

    //UI子弹数目UI
    public Text BulletCount_UI_Text;

    //重新装填弹药UI
    public GameObject Help_UI_Panel;

    // Use this for initialization
    void Start () {
        //初始化子弹数目为50发
        BulletCount = 50;

    }

    // Update is called once per frame
    void Update()
    {
        //点击鼠标左键
        //Input.GetMouseButtonDown - 0左键
        if (Input.GetMouseButtonDown(0)) {
            //Debug.Log("我按下了鼠标左键");

            //重复执行某一个方法
            InvokeRepeating("Fire", 0, 1/ FireSpeed);

        }

        //抬起鼠标左键
        if (Input.GetMouseButtonUp(0)) {
            //Debug.Log("我抬起了鼠标左键");

            //取消执行开火方法
            CancelInvoke("Fire");
        }

        //按下R键装填弹药
        if (Input.GetKeyDown(KeyCode.R)&& BulletCount!=50) {

            //执行装填方法
            ReLoad();

        }

    }

    //开火
    void Fire() {
        //Debug.Log("开火,时间为" + Time.timeSinceLevelLoad);


        if (BulletCount > 0)
        {
            //子弹数减少
            BulletCount -= 1;

            //更新UI子弹显示数值，注意使用toString方法
            BulletCount_UI_Text.text = BulletCount.ToString();

            //实例化一个克隆子弹
            GameObject newbullet = Instantiate(BulletPrefab);
            newbullet.name = "PlayerBullet";
            //调整坐标与角度
            //对齐坐标，否则子弹会出现在别处
            newbullet.transform.position = FirePoint.transform.position;
            //对齐角度，否则子弹会没有朝向枪口方向
            newbullet.transform.eulerAngles = FirePoint.transform.eulerAngles;
        }

        if (BulletCount == 0)
        {
            //停止开火
            CancelInvoke("Fire");
            //显示提示重新装弹UI
            Help_UI_Panel.SetActive(true);
        }

    }

    //重新装弹
    void ReLoad() {
        BulletCount = 50;
        //更新UI
        BulletCount_UI_Text.text = BulletCount.ToString();

        //提示信息消失
        Help_UI_Panel.SetActive(false);
    }


}
