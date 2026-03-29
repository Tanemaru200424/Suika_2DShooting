using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_attack : MonoBehaviour
{
    public GameObject attack1;
    public GameObject attack2;
    private float generateTime = 0.0f;
    private float interval = 2.0f;

    void Start()
    {
        generateTime = Random.Range(0, interval);
    }

    void Update()
    {
        generateTime += Time.deltaTime;
        if (generateTime >= interval)
        {
            generateTime = 0;
            Instantiate(attack1, transform.position, transform.rotation);
            Instantiate(attack2, transform.position, transform.rotation);
        }
    }
}
