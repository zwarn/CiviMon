using UnityEngine;

namespace DefaultNamespace
{
    public class Helper
    {
        public static Vector3 gameCoordsToWorld(Vector2Int gameCoords)
        {
            return new Vector3(gameCoords.x, gameCoords.y + gameCoords.x / 2.0f, 0);
        }
    }
}