using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreresult : MonoBehaviour
{
    private TextMeshProUGUI scoreText = null;  
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
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
