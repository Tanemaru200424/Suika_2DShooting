using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{

    public void OnClick()
    {

        SceneManager.LoadScene("ACTION");
        gamemanager.instance.score = 0;
        gamemanager.instance.zanki = 3;
        gamemanager.instance.suika = 2;

    }
}