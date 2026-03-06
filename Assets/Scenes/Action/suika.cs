using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class suika : MonoBehaviour
{
    private TextMeshProUGUI suikaText = null;
    private int oldsuika = 0;
    // Start is called before the first frame update
    void Start()
    {
        suikaText = GetComponent<TextMeshProUGUI>();
        if (gamemanager.instance != null)
        {
            suikaText.text = "スイカ " + gamemanager.instance.suika;
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (oldsuika != gamemanager.instance.suika)
        {
            suikaText.text = "スイカ " + gamemanager.instance.suika;
            oldsuika = gamemanager.instance.suika;
        }
    }
}
