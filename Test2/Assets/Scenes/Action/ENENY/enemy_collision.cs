using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_collision : MonoBehaviour
{
    public float hp;
    public int score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("プレイヤーとエンター");
        }
        else if (collision.gameObject.CompareTag("Pattack"))
        {
            Debug.Log("弾とエンター");
            hp -= 1;
            if (hp <= 0)
            {
                Destroy(this.gameObject);
                gamemanager.instance.score += score;
            }
        }
        else if (collision.gameObject.CompareTag("Bomb"))
        {
            Debug.Log("ボムとエンター");
            
                Destroy(this.gameObject);
                gamemanager.instance.score += score;
            
        }
        else if (collision.gameObject.CompareTag("EnemyBreaker"))
        {
            Debug.Log("敵を見逃した");

            Destroy(this.gameObject);
            

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("プレイヤーとステイ");
        }
        else if (collision.gameObject.CompareTag("Pattack"))
        {
            Debug.Log("弾とステイ");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("プレイヤーとイグジット");
        }
        else if (collision.gameObject.CompareTag("Pattack"))
        {
            Debug.Log("弾とイグジット");
        }
    }
}
