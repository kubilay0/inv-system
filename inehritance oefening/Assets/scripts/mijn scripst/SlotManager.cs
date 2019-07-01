using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{

    public InventorySlot[] inventorySlots;

    public void AddItemToSlot(ItemClass itemToAdd)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].item == null)
            {
                inventorySlots[i].AddItem(itemToAdd);
                break;
            }
        }
    }
}