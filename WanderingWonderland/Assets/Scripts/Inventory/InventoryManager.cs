using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] Inventory inventory;

    private void Awake()
    {
        inventory.OnItemRightClickedEvent += useItem;
    }

    private void useItem (Item item)
    {
        //code if using equipable items
    }


}
