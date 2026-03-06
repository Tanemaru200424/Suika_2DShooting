using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class start : MonoBehaviour
{
   
    public void PressStart()
    {
       
        SceneManager.LoadScene("ACTION");
        gamemanager.instance.score = 0;
        gamemanager.instance.zanki = 3;
        gamemanager.instance.suika = 2;
        
    }
}