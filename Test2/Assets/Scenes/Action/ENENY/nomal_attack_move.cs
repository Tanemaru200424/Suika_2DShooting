using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nomal_attack_move : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (GameObject.Find("Player").transform.position.y < this.transform.position.y)
        {
            speed = -speed;
        }

    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector3(0, speed, 0);
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);

    }
}
