using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenadethrowing : MonoBehaviour
{

    public float throwforce = 20f;
    public GameObject grenadeprefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ThrowGrenade();
        }
    }

    void ThrowGrenade()
    {
        GameObject granade = Instantiate(grenadeprefab, transform.position, transform.rotation);
        Rigidbody rb = granade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwforce, ForceMode.VelocityChange);
    }
}
