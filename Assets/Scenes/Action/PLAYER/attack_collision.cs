using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_collision : MonoBehaviour
{
    private bool isHit = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Pbreaker"))
        {
            if (!isHit)
            {
                isHit = true;
                player_action.instance.attacklimit += 1;
                Destroy(this.gameObject);
            }
        }
    }
}
