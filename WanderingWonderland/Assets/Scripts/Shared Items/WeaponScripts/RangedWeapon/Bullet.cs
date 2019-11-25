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

    void CollidedWithObject()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if((other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy") && other.GetComponent<Health>())
        {
            other.GetComponent<Health>().TakeDamage(damageValue);
            print(other.GetComponent<Health>().GetCurrentHealth());
        }
        CollidedWithObject();
    }

}
