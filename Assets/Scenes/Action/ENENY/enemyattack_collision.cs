using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack_collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("プレイヤーとエンター");
            Destroy(this.gameObject);
            
        }

    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
       
    }

}
