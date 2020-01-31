using System;
using model;
using UnityEngine;

namespace controller
{
    public class InputController : MonoBehaviour
    {
        public void Update()
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

            if (moveDirection.HasValue)
            {
                FindObjectOfType<GameController>().Move(moveDirection.Value);
            }
        }
    }
}