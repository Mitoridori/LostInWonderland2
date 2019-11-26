using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : BaseCollectible
{
    public override void ApplyEffect()
    {

    }
    private void Awake()
    {
        alison = FindObjectOfType<Alison>();

    }
    void PickupWood(int amount)
    {
        int i = alison.GetWood() + amount;
        alison.SetWood(i);
    }
    void UseWood(int amount)
    {

        if (alison.GetWood() < amount)
        {
            //Doesn't have enough coins
        }
        else
        {
            int i = alison.GetWood() - amount;
            alison.SetWood(i);
        }
    }
}
