using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] Inventory inventory;

    private void Awake()
    {
        inventory.OnItemRightClickedEvent += EquipFromInventory;
    }

    private void EquipFromInventory(Item item)
    {
        //code if using equipable items
    }


}
