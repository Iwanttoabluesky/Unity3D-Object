using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_03 : MonoBehaviour {

    public GameObject Gun01;
    public GameObject Gun02;

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Gun01.SetActive(true);
            Gun02.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Gun02.SetActive(true);
            Gun01.SetActive(false);
        }

    }
}
