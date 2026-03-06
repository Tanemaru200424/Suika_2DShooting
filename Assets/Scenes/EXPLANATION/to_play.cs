using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_play : MonoBehaviour
{
    public void PressToPlay()
    {

        SceneManager.LoadScene("ACTION");
        gamemanager.instance.score = 0;
        gamemanager.instance.zanki = 3;
        gamemanager.instance.suika = 2;
    }
}
