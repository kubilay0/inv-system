using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiles
{
    public Vector2 position;
    public Image item;

    public Tiles(Vector2 pos)
    {
        position = pos;
    }

    public void AddItem(Image newItem)
    {
        if (item == null)
        {
            item = newItem;
            item.rectTransform.position = position;
            Debug.Log(item.rectTransform.anchoredPosition);
        }
    }
}
