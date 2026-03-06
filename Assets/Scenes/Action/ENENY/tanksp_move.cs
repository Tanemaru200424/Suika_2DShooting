using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanksp_move : MonoBehaviour
{
    public float speed;
    public float haba;
    public float updownspeed;
    private float swing;
    private Rigidbody2D rb2d;
    private float time;

    // Use this for initialization
    void Start()
    {
        time = 0;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * updownspeed;

        swing = Mathf.Sin(time) * haba;


        rb2d.velocity = new Vector2(-speed, swing);

    }
}
