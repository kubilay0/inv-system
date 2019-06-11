using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    public List<Tiles> tiles = new List<Tiles>();
    public Vector2 startPos;
    public float sizeX = 10;
    public float sizeY = 10;
    public int rowAmount = 3;
    public int amountRow = 5;

    public Grid(Vector2 origin, float width, float height, int rows, int amountPerRow = 5)
    {
        startPos = origin;
        sizeX = width;
        sizeY = height;
        rowAmount = rows;
        amountRow = amountPerRow;
        tiles = DrawGrid();
    }

    private List<Tiles> DrawGrid()
    {
        List<Tiles> tiles = new List<Tiles>();
        Vector2 grid = new Vector2(startPos.x-sizeX/2, startPos.y+sizeY/2);
        int rowCount = 0;
        for(int i = 0; i < rowAmount*amountRow; i++)
        {
            grid.x += sizeX / amountRow;
            tiles.Add(new Tiles(grid));
            rowCount++;
            if(rowCount == amountRow)
            {
                rowCount = 0;
                grid.x = startPos.x - (sizeX / 2);
                grid.y -= sizeY / rowAmount;
            }
        }
        return tiles;
    }
}
