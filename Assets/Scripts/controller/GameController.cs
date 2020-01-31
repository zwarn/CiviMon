using System.Collections.Generic;
using model;
using UnityEngine;
using view;

namespace controller
{
    public class GameController : MonoBehaviour
    {
        public List<TerrainTile> terrainList;
        public Dictionary<Vector2Int, Tile> tiles = new Dictionary<Vector2Int, Tile>();

        private void Start()
        {
            var map = new GameObject("Map");
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    var position = new Vector2Int(x, y);
                    var terrain = terrainList[Random.Range(0, terrainList.Count)];
                    var tile = new Tile(terrain, position);
                    tiles.Add(position, tile);
                    var tileView = TileView.createGameObject(map, tile);
                    tile.View = tileView;
                }
            }
        }
    }
}