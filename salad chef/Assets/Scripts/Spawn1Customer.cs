using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn1Customer : MonoBehaviour
{
    float Timer = 30f;
    public GameObject customerObject;
    void Start()
    {
        Instantiate(customerObject, transform.position, transform.rotation);
    }
    
    void Update()
    {
        Timer -= Time.deltaTime;
        if (GameMana.currentTimer >= 0)
        {
            if (Timer <= 0f)
            {
                Instantiate(customerObject, transform.position, transform.rotation);
                Timer = 30f;

            }
        }
    }
}
