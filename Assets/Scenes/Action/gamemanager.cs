using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance = null;
    public int score;
    public int zanki;
    public int suika;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        //WebGLではゲームを閉じる機能を無効。
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if !UNITY_WEBGL
                Application.Quit();//ゲームプレイ終了
            #endif
        }
    }
}
