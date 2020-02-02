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
        public List<MonsterData> MonsterDatas;
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
            _monsters.Add(SetupMonster(new Vector2Int(0, 0), 0));
            _monsters.Add(SetupMonster(new Vector2Int(1, 1), 1));
            ActivateFirstMonster();
        }

        private Monster SetupMonster(Vector2Int position, int index)
        {
            var monster = new Monster(MonsterDatas[index], position);
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
            var target = _activeMonster.Position + moveDirection;
            if (tiles.ContainsKey(target))
            {
                _activeMonster.Move(moveDirection);
            }
        }

        public void EndTurn()
        {
            _monsters.ForEach(monster => monster.endTurn());
        }

        private void ActivateFirstMonster()
        {
            _activeMonster = _monsters[0];
            MarkActiveMonsterWithCircle();
        }
        
        public void ChangeActiveMonster()
        {
            _activeMonster = _monsters[(_monsters.IndexOf(_activeMonster) + 1) % _monsters.Count];
            MarkActiveMonsterWithCircle();
        }

        private void MarkActiveMonsterWithCircle()
        {
            selectionCircle.transform.parent = _activeMonster.MonsterView.transform;
            selectionCircle.transform.localPosition = Vector3.zero;
        }
    }
}