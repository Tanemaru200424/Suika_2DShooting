using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacker_attack : MonoBehaviour
{
    public GameObject attack;
    private float generateTime = 0.0f;
    private float interval = 1.5f;

    void Start()
    {
        generateTime = Random.Range(interval-1.0f, interval);
    }

    void Update()
    {
        generateTime += Time.deltaTime;
        if (generateTime >= interval)
        {
            generateTime = 0;
            Instantiate(attack, transform.position, transform.rotation);
        }
    }
}
