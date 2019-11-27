using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCollectible : MonoBehaviour
{
    public Health health;
    public Alison alison;
    public int amount;
    public int duration;
    public int Cost;
    
    public abstract void ApplyEffect();

    private void OnTriggerEnter(Collider other)
    {
        health = other.GetComponent<Health>();
        alison = other.GetComponent<Alison>();

        if (other.gameObject.tag == "Player")
        {
            ApplyEffect();
            gameObject.SetActive(false);
        }

    }

}
