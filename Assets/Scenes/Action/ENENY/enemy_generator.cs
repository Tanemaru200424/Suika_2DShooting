using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_generator : MonoBehaviour
{
    [System.Serializable] public struct GenerateInfo
    {
        public int weight;
        public GameObject enemy;
    };
    public List<GenerateInfo> nomalGenerateInfoList = new List<GenerateInfo>();
    private int totalNomalWeight = 0;
    public List<GenerateInfo> spGenerateInfoList = new List<GenerateInfo>();
    private int totalSPWeight = 0;

    public int generateX = 20, generateMinY = -10, generateMaxY = 10; // ê∂ê¨îÕàÕ

    private float intervalTime = 0; // ê∂ê¨Ç∑ÇÈä‘äu
    private float intervalLevel0 = 3.0f;
    private float intervalLevel1 = 2.75f;
    private float intervalLevel2 = 2.5f;

    void Start()
    {
        intervalTime = intervalLevel0;
        foreach (GenerateInfo info in nomalGenerateInfoList)
        {
            totalNomalWeight += info.weight;
        }
        foreach (GenerateInfo info in spGenerateInfoList)
        {
            totalSPWeight += info.weight;
        }
    }

    void Update()
    {
        intervalTime -= Time.deltaTime;

        if (intervalTime <= 0)
        {
            float nowScore = gamemanager.instance.score;
            if(nowScore >= 2000)
            {
                GenerateNomalEnemy();
                GenerateNomalEnemy();
                GenerateSPEnemy();
                GenerateSPEnemy();
                if (nowScore >= 4000) { intervalTime = intervalLevel2; }
                else if (nowScore >= 3000) { intervalTime = intervalLevel1; }
                else { intervalTime = intervalLevel0; }
            }
            else if(nowScore >= 1000)
            {
                GenerateNomalEnemy();
                GenerateNomalEnemy();
                GenerateSPEnemy();
                intervalTime = intervalLevel0;
            }
            else if(nowScore >= 500)
            {
                GenerateNomalEnemy();
                GenerateSPEnemy();
                intervalTime = intervalLevel0;
            }
            else
            {
                GenerateNomalEnemy();
                GenerateNomalEnemy();
                intervalTime = intervalLevel0;
            }
        }
    }

    private void GenerateNomalEnemy()
    {
        int randWeight = 0;
        int nowIndex = 0;
        randWeight = Random.Range(1, totalNomalWeight+1); //intÇ»ÇÃÇ≈MaxÇ‡ä‹ÇﬁÇÊÇ§+1
        while(randWeight > nomalGenerateInfoList[nowIndex].weight)
        {
            randWeight -= nomalGenerateInfoList[nowIndex].weight;
            nowIndex++;
        }

        float generateRandY = Random.Range(generateMinY, generateMaxY+1);
        Instantiate(nomalGenerateInfoList[nowIndex].enemy, new Vector3(generateX, generateRandY, 0), Quaternion.identity);
    }
    private void GenerateSPEnemy()
    {
        int randWeight = 0;
        int nowIndex = 0;
        randWeight = Random.Range(1, totalSPWeight + 1); //intÇ»ÇÃÇ≈MaxÇ‡ä‹ÇﬁÇÊÇ§+1
        while (randWeight > spGenerateInfoList[nowIndex].weight)
        {
            randWeight -= spGenerateInfoList[nowIndex].weight;
            nowIndex++;
        }

        float generateRandY = Random.Range(generateMinY, generateMaxY+1);
        Instantiate(spGenerateInfoList[nowIndex].enemy, new Vector3(generateX, generateRandY, 0), Quaternion.identity);
    }
}