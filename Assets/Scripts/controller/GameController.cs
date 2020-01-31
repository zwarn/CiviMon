using System.Collections.Generic;
using model;
using UnityEngine;
using view;
using TerrainData = view.TerrainData;

namespace controller
{
    public class GameController : MonoBehaviour
    {
        public List<TerrainData> terrainList;
        public MonsterData MonsterData;
        public Dictionary<Vector2Int, Tile> tiles = new Dictionary<Vector2Int, Tile>();

        private void Start()
        {
            SetupMap();
            SetupMonster();
        }

        private void SetupMonster()
        {
            var position = new Vector2Int(0,0);
            var monster = new Monster(MonsterData, position);
            var monsterView = MonsterView.createGameObject(monster);
        }
        
        private void SetupMap()
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