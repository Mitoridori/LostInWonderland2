using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCollectible : MonoBehaviour
{
    public Health health;
    public int amount;
    public abstract void ApplyEffect();

    private void OnTriggerEnter(Collider other)
    {
        health = other.GetComponent<Health>();

        if (other.gameObject.tag == "Player")
        {
            ApplyEffect();
        }

    }

}
