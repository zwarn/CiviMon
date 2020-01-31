using UnityEngine;
using view;

namespace model
{
    public class Monster
    {
        public MonsterData Data { get; }
        public Vector2Int Position { get; set; }
        
        public MonsterView MonsterView { get; set; }

        public Monster(MonsterData data, Vector2Int position)
        {
            Data = data;
            Position = position;
        }

        public void Move(Vector2Int moveDirection)
        {
            Position += moveDirection;
            MonsterView.Redraw();
        }
    }
}