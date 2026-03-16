using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public void End()
    {
        //WebGLではゲームを閉じる機能を無効。
        #if !UNITY_WEBGL
            Application.Quit();//ゲームプレイ終了
        #endif
    }
}
