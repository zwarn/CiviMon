using System;
using UnityEngine;

namespace view
{
    [CreateAssetMenu(fileName = "Monster", menuName = "ScriptableObjects/Monster")]
    public class MonsterData : ScriptableObject
    {
        public Sprite sprite;
        public String name;
    }
}