using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_generator : MonoBehaviour
{
    public List<GameObject> enemyList;    // 生成オブジェクト
    public float x,y;                   // 生成範囲

    public float frame;
    public int generateFrame;        // 生成する間隔

    void Start()
    {
        
    }

    void Update()
    {
        frame += Time.deltaTime * 100;

        if (frame > generateFrame)
        {
            frame = 0;

            // ランダムで種類と位置を決める
            int index = Random.Range(0, enemyList.Count);
            float posX = Random.Range(x,x);
            float posY = Random.Range(-y,y);

            Instantiate(enemyList[index], new Vector3(posX, posY, 0), Quaternion.identity);
        }
    }
}