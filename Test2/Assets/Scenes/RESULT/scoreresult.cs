using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreresult : MonoBehaviour
{
   
    private Text scoreText = null;
   
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        if (gamemanager.instance != null)
        {
            scoreText.text = "ƒŠƒUƒ‹ƒg " + gamemanager.instance.score;
        }
        else
        {
            Destroy(this);
        }
    }

   
}
