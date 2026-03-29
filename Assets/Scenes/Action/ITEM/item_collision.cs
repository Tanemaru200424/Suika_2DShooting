using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_collision : MonoBehaviour
{
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            gamemanager.instance.suika += 1;
            gamemanager.instance.zanki += 1;
        }
       
    }
    
}
