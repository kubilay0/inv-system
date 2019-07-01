using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Item", menuName = "Inventory/Create new Item")]
public class Item : ScriptableObject
{
    public Sprite icon;
    public int stackLimit;
    public int stack;
    public new string name;
    public string description;
    public bool dragable;

    public void AddToStack(int amount)
    {
        if (stack + amount < stackLimit)
            stack += amount;
        else
            Debug.LogWarning("Your inventory is full");
    }
}
