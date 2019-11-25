using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int firingSpeed;
    public int damageValue;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(rb)
        {
            rb.velocity = transform.up * firingSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }

}
