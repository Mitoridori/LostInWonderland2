using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplishmentRemedy : BaseCollectible
{
    public override void ApplyEffect()
    {
        health.Heal(amount);
        Debug.Log("You gained health!");
    }

}
