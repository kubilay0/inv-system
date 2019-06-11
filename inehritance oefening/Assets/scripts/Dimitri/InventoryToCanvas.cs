using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryToCanvas : MonoBehaviour
{
    [SerializeField]
    private Canvas targetCanvas;
    public int rows = 3;
    public Inventory inventoryToCast;
    public Vector2 spacing;
    private List<GameObject> drawnObjects = new List<GameObject>();
    private List<Vector2> points = new List<Vector2>();
    public Grid grid;
    private void Start()
    {
        grid = new Grid(new Vector2(-100,0), targetCanvas.pixelRect.width, targetCanvas.pixelRect.height, 6, 5);
        DrawInventory();
        inventoryToCast.AddedItem += DrawInventory;
        inventoryToCast.ItemHasBeenRemoved += DrawInventory;
    }

    private void DrawInventory()
    {
        EmptyCanvas();
        foreach(Item item in inventoryToCast.items)
        {
            GameObject sprite = new GameObject();
            Image spriteIcon = sprite.AddComponent<Image>().GetComponent<Image>();
            spriteIcon.sprite = item.icon;
            sprite.transform.parent = targetCanvas.transform;
            for(int i = 0; i < grid.tiles.Count-1; i++)
            {
                if (grid.tiles[i].item == null)
                {
                    grid.tiles[i].AddItem(spriteIcon);
                    i = grid.tiles.Count - 1;
                }
            }
            spriteIcon.rectTransform.localPosition = new Vector3(spriteIcon.rectTransform.position.x, spriteIcon.rectTransform.position.y, 0);
            spriteIcon.rectTransform.sizeDelta = new Vector3(10, 10, 1);
        }
    }

    private void EmptyCanvas()
    {
        foreach(GameObject canvasPiece in drawnObjects)
        {
            Destroy(canvasPiece);
        }
    }

}
