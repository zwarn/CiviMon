using UnityEngine;

namespace model
{
    public class Direction
    {
        public static Vector2Int Up = new Vector2Int(0, 1);
        public static Vector2Int Down = new Vector2Int(0, -1);
        public static Vector2Int UpperLeft = new Vector2Int(-1,1);
        public static Vector2Int LowerLeft = new Vector2Int(-1, 0);
        public static Vector2Int UpperRight = new Vector2Int(1,0);
        public static Vector2Int LowerRight = new Vector2Int(1,-1);
    }
}