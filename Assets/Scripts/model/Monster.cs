using UnityEngine;
using view;

namespace model
{
    public class Monster
    {
        public MonsterData Data { get; }
        public Vector2Int Position { get; }

        public Monster(MonsterData data, Vector2Int position)
        {
            Data = data;
            Position = position;
        }
    }
}