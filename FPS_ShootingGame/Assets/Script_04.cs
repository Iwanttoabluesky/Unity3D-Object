using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Script_04 : MonoBehaviour {

    public Text HP_UI_Text;

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Player") {

            other.GetComponent<Player>().HP -= 1;
            HP_UI_Text.text = other.GetComponent<Player>().HP.ToString();

        }
    }


}
