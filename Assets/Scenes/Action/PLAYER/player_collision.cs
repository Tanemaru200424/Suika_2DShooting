using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("敵とエンター");
            gamemanager.instance.zanki -= 1;
            StartCoroutine("Muteki");
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
    IEnumerator Muteki()
    {
        Debug.Log("無敵");
        this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
        // １０回点滅
        for (int i = 0; i < 10; i++)
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(0.2f);
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(0.2f);
        }
        Debug.Log("無敵終わり");
        this.gameObject.layer = LayerMask.NameToLayer("Default");

    }
}