using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zanki : MonoBehaviour
{
    private Text zankiText = null;
    private int oldzanki = 0;
    // Start is called before the first frame update
    void Start()
    {
        zankiText = GetComponent<Text>();
        if (gamemanager.instance != null)
        {
            zankiText.text = "残機 " + gamemanager.instance.zanki;
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (oldzanki != gamemanager.instance.zanki)
        {
            zankiText.text = "残機 " + gamemanager.instance.zanki;
            oldzanki = gamemanager.instance.zanki;
        }
    }
}