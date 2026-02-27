using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_attack : MonoBehaviour
{
    public GameObject attack1;
    public GameObject attack2;
    public float frame;
    public int generateFrame;
    void Update()
    {
        frame += Time.deltaTime * 100;
        if (frame > generateFrame)
        {
            frame = 0;
            Instantiate(attack1, transform.position, transform.rotation);
            Instantiate(attack2, transform.position, transform.rotation);

        }
    }
}
