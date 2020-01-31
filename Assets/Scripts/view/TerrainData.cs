using UnityEngine;

namespace view
{
    [CreateAssetMenu(fileName = "Terrain", menuName = "ScriptableObjects/Terrain")]
    public class TerrainData : ScriptableObject
    {
        public Sprite sprite;
    }
}