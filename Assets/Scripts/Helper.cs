using UnityEngine;

namespace DefaultNamespace
{
    public class Helper
    {
        public static Vector3 gameCoordsToWorld(Vector2Int gameCoords)
        {
            return new Vector3(gameCoords.x + gameCoords.y / 2.0f, gameCoords.y * 0.75f, 0);
        }
    }
}