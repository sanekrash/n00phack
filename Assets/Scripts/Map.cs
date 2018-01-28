using UnityEditor;
using UnityEngine;

public class Map
{
    public Tile[,] Tiles;
    public Map(int x, int y, Tile tile)
    {
        Tiles = new Tile[x, y];
    }
    public Matrix GetMatrix()
    {
        return new Matrix(15, 15, new Char('H', Color.green, Color.red));
    }
    public Tile this[int x, int y]
    {
        get { return Tiles[x, y]; }
        set { Tiles[x, y] = value; }
    }
}