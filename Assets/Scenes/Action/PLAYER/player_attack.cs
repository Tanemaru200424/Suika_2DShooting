using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class player_attack : MonoBehaviour
{
    public GameObject pattack;
    public GameObject spattack1;
    public GameObject spattack2;
    public GameObject spattack3;
    public GameObject spattack4;
    public GameObject spattack5;
    public int attacklimit;
    public static player_attack instance = null;
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

    public void OnFire(InputAction.CallbackContext context)
    {
        push = context.ReadValue<float>();
        if (context.phase == InputActionPhase.Started && attacklimit > 0)
        {
            Debug.Log("Fire");
            attacklimit -= 1;
            Instantiate(pattack, transform.position, transform.rotation);
        }
    }

    public void OnBomb(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Debug.Log("‚Ô‚Á‚Ï");
            if (gamemanager.instance.suika > 0)
            {

                gamemanager.instance.suika -= 1;
                Instantiate(spattack1, transform.position, transform.rotation);
                Instantiate(spattack2, transform.position, transform.rotation);
                Instantiate(spattack3, transform.position, transform.rotation);
                Instantiate(spattack4, transform.position, transform.rotation);
                Instantiate(spattack5, transform.position, transform.rotation);
            }
        }
    }

    void Update()
    {
        if(push != 0.0f && attacklimit > 0)
        {
            frame += Time.deltaTime * 100;
            if(frame >= generateframe)
            {
                Debug.Log("Fire");
                attacklimit -= 1;
                Instantiate(pattack, transform.position, transform.rotation);
                frame = 0.0f;
            }
        }
        else
        {
            frame = 0.0f;
        }
    }
}