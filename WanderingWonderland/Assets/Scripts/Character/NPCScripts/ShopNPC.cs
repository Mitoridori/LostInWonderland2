using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopNPC : NPCController
{
    public ShopUIManager SUIM;
    public Inventory inventory;
    BaseCollectible BC;
    public Item ReplenishRemedy;
    public Item PunishmentPunch;
    public Item SwiftSoda;

    void Awake()
    {
        SUIM = FindObjectOfType<ShopUIManager>();
        inventory = FindObjectOfType<Inventory>();
   
    }


    public override void Interact()
    {

        //interaction with person
    }

    public void PunishmentPunchGive()
    {
        inventory.Add(PunishmentPunch);
        
    }

    public void ReplenishRemedyGive()
    {
        inventory.Add(ReplenishRemedy);
    }

    public void SwiftSodaGive()
    {
        inventory.Add(SwiftSoda);
    }
}
