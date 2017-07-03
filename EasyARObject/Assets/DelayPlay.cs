using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class DelayPlay : MonoBehaviour
{
    void Start()
    {
        Invoke("PlaySound", 2f);
    }

    void PlaySound()
    {
        this.GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
