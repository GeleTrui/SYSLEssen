using System;

namespace Kamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Kamer room1 = new Kamer(5, 5);
        }
    }

    class Tile
    {

    }
    class Kamer
    {
        Tile[][] TileMap;

        public Kamer(int width, int height)
        {
            TileMap = new Tile[height][];
            for (int i = 0; i < TileMap.Length; i++)
            {
                TileMap[i] = new Tile[width];
                for (int j = 0; j < TileMap[i].Length; j++)
                {

                    TileMap[i][j] = new Tile();

                }
            }
        }
    }
}