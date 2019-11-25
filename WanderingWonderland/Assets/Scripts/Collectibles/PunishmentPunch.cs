using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunishmentPunch : BaseCollectible
{
    //don't remove
    public override void ApplyEffect()
    {
        //execute the functions from the player by calling player. (whatever function from the player)
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ApplyEffect();
        }
    }

}
