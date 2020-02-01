using System;
using UnityEngine;
using view;

namespace model
{
    public class Monster
    {
        public Vector2Int Position { get; set; }
        
        public MonsterView MonsterView { get; set; }
        public Sprite Sprite { get; }
        public string Name { get; }
        public int MaxActions { get; }
        public int Actions { get; set; }

        public Monster(MonsterData data, Vector2Int position)
        {
            Sprite = data.sprite;
            Name = data.name;
            MaxActions = 2;
            Actions = MaxActions;
            Position = position;
        }

        public void Move(Vector2Int moveDirection)
        {
            if (Actions >= 1)
            {
                Actions -= 1;
                Position += moveDirection;
                MonsterView.Redraw();
            }
        }

        public void endTurn()
        {
            Actions = MaxActions;
        }
    }
}