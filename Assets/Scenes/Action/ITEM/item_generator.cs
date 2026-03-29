using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_generator : MonoBehaviour
{
    public List<GameObject> itemList;    // 生成オブジェクト
    public int minx = -10, maxx = 0, miny = -11, maxy = 11;   // 生成範囲

    private float saveScore = 0;
    public float intervalScore = 2500;

    private float generateTime = 0;
    private float intervalTime = 60;

    void Update()
    {
        float nowScore = gamemanager.instance.score;
        if (saveScore < nowScore && nowScore - saveScore >= intervalScore)
        {
            while (nowScore - saveScore >= intervalScore)
            {
                saveScore += intervalScore;
                GenerateItem();
            }
        }

        if(gamemanager.instance.score >= 3000)
        {
            generateTime += Time.deltaTime;
            if(generateTime >= intervalTime)
            {
                generateTime = 0;
                GenerateItem();
            }
        }
    }

    private void GenerateItem()
    {
        // ランダムで種類と位置を決める
        int index = Random.Range(0, itemList.Count);
        float posX = Random.Range(minx, maxx+1);
        float posY = Random.Range(miny, maxy+1);

        Instantiate(itemList[index], new Vector3(posX, posY, 0), Quaternion.identity);
    }
}