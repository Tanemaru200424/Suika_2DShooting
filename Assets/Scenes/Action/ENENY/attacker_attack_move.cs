using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacker_attack_move : MonoBehaviour
{
    public float xspeed;
    public float yspeed;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").transform.position.y > transform.position.y)
        {
            rb2d.velocity = new Vector2(-xspeed, yspeed);
        }
        else if (GameObject.Find("Player").transform.position.y < transform.position.y)
        {
            rb2d.velocity = new Vector2(-xspeed, -yspeed);
        }
        else if (GameObject.Find("Player").transform.position.y == transform.position.y)
        {
            rb2d.velocity = new Vector2(-xspeed, 0);
        }
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);

    }
}
