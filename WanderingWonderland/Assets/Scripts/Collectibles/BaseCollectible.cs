using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCollectible : MonoBehaviour
{
    public Health health;
    public Alison alison;
    public Inventory inventory;
    public Item item;
    public int amount;
    public int duration;
    public int Cost;

    public abstract void ApplyEffect();
    private void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        inventory.Add(item);   // Add to inventory

        gameObject.SetActive(false);    // Destroy item from scene
    }

    private void OnTriggerEnter(Collider other)
    {
        health = other.GetComponent<Health>();
        alison = other.GetComponent<Alison>();

        if (other.gameObject.tag == "Player")
        {
            PickUp();
            gameObject.SetActive(false);
            

        }

    }

}
