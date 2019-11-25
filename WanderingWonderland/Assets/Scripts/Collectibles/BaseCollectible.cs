using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCollectible : MonoBehaviour
{
    Alison alison;

    public abstract void ApplyEffect();

    // Start is called before the first frame update
    void Start()
    {
        alison = FindObjectOfType<Alison>();
    }
}
