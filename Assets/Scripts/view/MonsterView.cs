using controller;
using DefaultNamespace;
using model;
using UnityEngine;

namespace view
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class MonsterView : MonoBehaviour
    {
        public Monster Monster;

        public void Redraw()
        {
            gameObject.transform.position = Helper.gameCoordsToWorld(Monster.Position);
            GetComponent<SpriteRenderer>().sprite = Monster.Sprite;
        }

        public static MonsterView createGameObject(Monster monster)
        {
            var position = monster.Position;
            var monsterObject = new GameObject(monster.Name);
            monsterObject.AddComponent<SpriteRenderer>();
            monsterObject.GetComponent<SpriteRenderer>().sortingOrder = 10;
            monsterObject.AddComponent<MonsterView>();
            var monsterView = monsterObject.GetComponent<MonsterView>();
            monsterView.Monster = monster;
            monsterView.Redraw();
            return monsterView;
        }
    }
}