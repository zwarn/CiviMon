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
            GetComponent<SpriteRenderer>().sprite = Monster.Data.sprite;
        }

        public static MonsterView createGameObject(Monster monster)
        {
            var position = monster.Position;
            var monsterObject = new GameObject(monster.Data.name);
            monsterObject.transform.Translate(Helper.gameCoordsToWorld(position));
            monsterObject.AddComponent<SpriteRenderer>();
            monsterObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
            monsterObject.AddComponent<MonsterView>();
            var monsterView = monsterObject.GetComponent<MonsterView>();
            monsterView.Monster = monster;
            monsterView.Redraw();
            return monsterView;
        }
    }
}