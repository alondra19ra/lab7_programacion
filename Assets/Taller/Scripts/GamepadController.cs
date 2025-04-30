using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamepadController : IPlayerController
{
    public void Move()
    {
        Debug.Log("Movimiento Gamepad");
    }
    public void Attack()
    {
        Debug.Log("Ataque Gamepad");
    }
}
