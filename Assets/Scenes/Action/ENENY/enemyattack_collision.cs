using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack_collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Bomb") || collision.gameObject.CompareTag("Ebreaker"))
        {
            Destroy(this.gameObject);
        }
    }
}
