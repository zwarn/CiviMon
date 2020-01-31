using UnityEngine;

namespace view
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TerrainTile")]
    public class TerrainTile : ScriptableObject
    {
        public Sprite sprite;
    }
}