using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_reborn : MonoBehaviour
{
    public GameObject start;
    
    void Start()
    {
        transform.position = start.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gamemanager.instance.zanki > 0)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                transform.position = start.transform.position;
                
            }
        }
        else
        {
            SceneManager.LoadScene("RESULT");
        }
    }

}
