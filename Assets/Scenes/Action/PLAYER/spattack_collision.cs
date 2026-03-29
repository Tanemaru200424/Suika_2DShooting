using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spattack_collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pbreaker"))
        {
            Destroy(this.gameObject);
        }
    }
}
