using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{

    public ItemClass item;
    public Image itemImage;

    public void AddItem(ItemClass i)
    {
        item = i;
        itemImage.enabled = true;
        itemImage.sprite = item.image;
    }

    public void DropItem()
    {
        Instantiate(item.GO, GameObject.FindGameObjectWithTag("Player").transform.position + new Vector3(3, 0, 0), Quaternion.identity);
        item = null;
        itemImage.sprite = null;

       itemImage.enabled = false;
    }
}