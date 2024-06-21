using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{

    public float delay = 2f;
    float countdown;
    bool hasExploded = false;

    public GameObject explosioneffect;


    void Start()
    {
        countdown = delay;
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && hasExploded == false)
        {
            Explode();
        }
    }

    void Explode()
    {
        Instantiate(explosioneffect, transform.position, transform.rotation);
        Destroy(gameObject);
        
        
        hasExploded = true;

    }
}
