using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_generator : MonoBehaviour
{
    public List<GameObject> itemList;    // 生成オブジェクト
    public float minx,maxx,y;                   // 生成範囲

    public float frame = 0;
    public int generateFrame;        // 生成する間隔

    void Start()
    {
        
    }

    void Update()
    {
        frame += Time.deltaTime * 100;

        if (frame >= generateFrame)
        {
            frame = 0;

            // ランダムで種類と位置を決める
            int index = Random.Range(0, itemList.Count);
            float posX = Random.Range(minx,maxx);
            float posY = Random.Range(-y,y);

            Instantiate(itemList[index], new Vector3(posX, posY, 0), Quaternion.identity);
        }
    }
}