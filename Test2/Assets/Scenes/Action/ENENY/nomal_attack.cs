using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nomal_attack : MonoBehaviour
{
    public GameObject attack;
    public float frame;
    public int generateFrame;
    void Update()
    {
        frame += Time.deltaTime * 100;
        if (frame > generateFrame)
        {
            frame = 0;
            Instantiate(attack, transform.position, transform.rotation);
            
        }
    }
}
