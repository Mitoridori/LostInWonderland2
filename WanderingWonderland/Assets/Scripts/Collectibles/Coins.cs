using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coins : BaseCollectible
    
{
    private void Awake()
    {
        alison = FindObjectOfType<Alison>();

    }
    public override void ApplyEffect()
    {

    }

    void PickupCoins(int amount)
    {
        int i = alison.GetCoin() + amount;
        alison.SetCoin(i);
    }
    void UseCoins(int amount)
    {
        
        if (alison.GetCoin() < amount)
        {
            //Doesn't have enough coins
        }
        else
        {
            int i = alison.GetCoin() - amount;
            alison.SetCoin(i);
        }
    }

    
}
