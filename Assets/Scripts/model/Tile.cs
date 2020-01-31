using UnityEngine;
using view;
using TerrainData = view.TerrainData;

namespace model
{
    public class Tile
    {
        public Vector2Int Position { get; }
        public TerrainData Terrain { get; }

        public TileView View { get; set; }

        public Tile(TerrainData terrain, Vector2Int position)
        {
            Position = position;
            Terrain = terrain;
        }
    }
}