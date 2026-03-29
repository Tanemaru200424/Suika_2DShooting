using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class player_action : MonoBehaviour
{
    public float speed;
    public float xLimit;
    public float yLimit;
    private Rigidbody2D rb;
    private float xspeed;
    private float yspeed;
    private Vector2 move;

    public GameObject pattack;
    public GameObject spattack1;
    public GameObject spattack2;
    public GameObject spattack3;
    public GameObject spattack4;
    public GameObject spattack5;
    public int attacklimit;
    public static player_action instance = null;
    public float frame;
    public float generateframe;
    private float push;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
        xspeed = move.x;
        yspeed = move.y;
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        push = context.ReadValue<float>();
        if (context.phase == InputActionPhase.Started && attacklimit > 0)
        {
            attacklimit -= 1;
            Instantiate(pattack, new Vector3(transform.position.x+1,transform.position.y,transform.position.z), transform.rotation);
        }
    }

    public void OnBomb(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started && gamemanager.instance.suika > 0)
        {
            gamemanager.instance.suika -= 1;
            Instantiate(spattack1, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
            Instantiate(spattack2, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
            Instantiate(spattack3, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
            Instantiate(spattack4, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
            Instantiate(spattack5, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
        }
    }

    public void OnInterruption(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            SceneManager.LoadScene("RESULT");
        }
    }

    void Update()
    {        
        rb.velocity = new Vector2(xspeed * speed, yspeed * speed);
        Vector2 currentposition = transform.position;
        currentposition.x = Mathf.Clamp(currentposition.x, -xLimit, xLimit);
        currentposition.y = Mathf.Clamp(currentposition.y, -yLimit, yLimit);
        transform.position = currentposition;

        if (push != 0.0f && attacklimit > 0)
        {
            frame += Time.deltaTime * 100;
            if (frame >= generateframe)
            {
                attacklimit -= 1;
                Instantiate(pattack, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
                frame = 0.0f;
            }
        }
        else
        {
            frame = 0.0f;
        }
    }
}
