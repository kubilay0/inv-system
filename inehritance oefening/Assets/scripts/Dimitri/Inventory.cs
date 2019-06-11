using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    public List<Item> items = new List<Item>();
    private int space = 10;
    public int Space { protected set { space = value; } get { return space; } }
    public Action AddedItem;
    public Action ItemHasBeenRemoved;

    public bool isFull()
    {
        if(items.Count >= space)
        {
            return true;
        }
        return false;
    }

    public void AddItem(Item newItem, int amount = 1)
    {
        if (items.Contains(newItem) && !isFull())
        {
            AddedItem?.Invoke();
            items.Find(Item => newItem).AddToStack(amount);
            return;
        }
        if (!isFull())
        {
            AddedItem?.Invoke();
            newItem.AddToStack(amount);
            items.Add(newItem);
        }
    }

    public void RemoveItem(Item itemToRemove)
    {
        if (items.Contains(itemToRemove))
        {
            if(items.Find(Item => itemToRemove).stack == 1)
            {
                ItemHasBeenRemoved?.Invoke();
                items.Remove(itemToRemove);
                return;
            }
            ItemHasBeenRemoved?.Invoke();
            items.Find(Item => itemToRemove).stack--;
        }
    }
}
