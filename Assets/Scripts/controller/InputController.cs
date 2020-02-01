using System;
using model;
using UnityEngine;

namespace controller
{
    public class InputController : MonoBehaviour
    {
        private GameController _gameController;

        private void Start()
        {
            _gameController = GetComponent<GameController>();
        }

        public void Update()
        {
            var moveDirection = MoveButtons();

            if (moveDirection.HasValue)
            {
                _gameController.Move(moveDirection.Value);
            }

            if (Input.GetKeyUp(KeyCode.Return))
            {
                _gameController.EndTurn();
            }

            if (Input.GetKeyUp(KeyCode.Tab))
            {
                _gameController.ChangeActiveMonster();
            }
        }

        private static Vector2Int? MoveButtons()
        {
            Vector2Int? moveDirection = null;
            if (Input.GetKeyUp(KeyCode.Keypad8))
            {
                moveDirection = Direction.Up;
            }

            if (Input.GetKeyUp(KeyCode.Keypad2))
            {
                moveDirection = Direction.Down;
            }

            if (Input.GetKeyUp(KeyCode.Keypad7))
            {
                moveDirection = Direction.UpperLeft;
            }

            if (Input.GetKeyUp(KeyCode.Keypad9))
            {
                moveDirection = Direction.UpperRight;
            }

            if (Input.GetKeyUp(KeyCode.Keypad1))
            {
                moveDirection = Direction.LowerLeft;
            }

            if (Input.GetKeyUp(KeyCode.Keypad3))
            {
                moveDirection = Direction.LowerRight;
            }

            return moveDirection;
        }
    }
}