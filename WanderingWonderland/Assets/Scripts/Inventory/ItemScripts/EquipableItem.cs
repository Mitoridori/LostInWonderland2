using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType
{
    Bow,
    Sword,
    Dagger

}

[CreateAssetMenu]
public class EquipableItem : Item
{
    public int DamageBonus;

    public EquipmentType EquipmentType;

}
