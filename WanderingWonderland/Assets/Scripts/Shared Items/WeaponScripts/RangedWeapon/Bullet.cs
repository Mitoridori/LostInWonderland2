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
        if (rb)
        {
            rb.velocity = transform.up * firingSpeed;
        }
    }

    void CollidedWithObject()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.GetComponent<Health>() && other.gameObject.tag == "Player")
        {
            other.GetComponent<Health>().TakeDamage(damageValue);
        }
        CollidedWithObject();
    }

}
