using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Eattack"))
        {
            gamemanager.instance.zanki -= 1;
            if (gamemanager.instance.zanki <= 0) { SceneManager.LoadScene("RESULT"); }
            else { StartCoroutine("Muteki"); }
        }
    }

    IEnumerator Muteki()
    {
        this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.3f);
        yield return new WaitForSeconds(5);
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        this.gameObject.layer = LayerMask.NameToLayer("Default");

    }
}