using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("敵とエンター");
            Destroy(this.gameObject);
            player_action.instance.attacklimit += 1;
        }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("敵とステイ");
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("敵とイグジット");
           
        }
        
    }
}
