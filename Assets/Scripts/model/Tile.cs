using UnityEngine;
using view;

namespace model
{
    public class Tile
    {
        public Vector2Int Position { get; }
        public TerrainTile Terrain { get; }

        public TileView View { get; set; }

        public Tile(TerrainTile terrain, Vector2Int position)
        {
            Position = position;
            Terrain = terrain;
        }
    }
}