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
        public GameObject selectionCircle;
        private List<Monster> _monsters = new List<Monster>();
        private Monster _activeMonster;

        private void Start()
        {
            SetupMap();
            SetupMonsters();
        }

        private void SetupMonsters()
        {
            _monsters.Add(SetupMonster(new Vector2Int(0,0)));
            _monsters.Add(SetupMonster(new Vector2Int(1,1)));
            _activeMonster = _monsters[0];
        }

        private Monster SetupMonster(Vector2Int position)
        {
            var monster = new Monster(MonsterData, position);
            var monsterView = MonsterView.createGameObject(monster);
            monster.MonsterView = monsterView;
            return monster;
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

        public void Move(Vector2Int moveDirection)
        {
            _activeMonster.Move(moveDirection);
        }

        public void EndTurn()
        {
            _monsters.ForEach(monster => monster.endTurn());
        }

        public void ChangeActiveMonster()
        {
            _activeMonster = _monsters[(_monsters.IndexOf(_activeMonster) + 1) % _monsters.Count];
            selectionCircle.transform.position = _activeMonster.MonsterView.gameObject.transform.position;
        }
    }
}