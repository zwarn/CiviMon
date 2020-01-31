using controller;
using DefaultNamespace;
using model;
using UnityEngine;

namespace view
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class TileView : MonoBehaviour
    {
        public Tile tile;

        public void Redraw()
        {
            GetComponent<SpriteRenderer>().sprite = tile.Terrain.sprite;
        }

        public static TileView createGameObject(GameObject map, Tile tile)
        {
            var position = tile.Position;
            var tileObject = new GameObject(position.x + " : " + position.y);
            tileObject.transform.Translate(Helper.gameCoordsToWorld(position));
            tileObject.AddComponent<SpriteRenderer>();
            tileObject.AddComponent<TileView>();
            tileObject.transform.SetParent(map.transform);
            var tileView = tileObject.GetComponent<TileView>();
            tileView.tile = tile;
            tileView.Redraw();
            return tileView;
        }
    }
}