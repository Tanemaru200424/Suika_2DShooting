using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_collision : MonoBehaviour
{
    public float hp;
    public int score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pattack"))
        {
            hp -= 1;
            if (hp <= 0)
            {
                Destroy(this.gameObject);
                gamemanager.instance.score += score;
            }
        }
        else if (collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(this.gameObject);
            gamemanager.instance.score += score;
        }
        else if (collision.gameObject.CompareTag("Ebreaker"))
        {
            Destroy(this.gameObject);
        }
    }
}
