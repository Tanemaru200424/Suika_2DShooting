using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    private TextMeshProUGUI scoreText = null;
    public int oldscore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        if (gamemanager.instance != null)
        {
            scoreText.text = "スコア " + gamemanager.instance.score;
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (oldscore != gamemanager.instance.score)
        {
            scoreText.text = "スコア " + gamemanager.instance.score;
            oldscore = gamemanager.instance.score;
        }
    }
}
