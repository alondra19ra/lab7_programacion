using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : IPlayerController
{
    public void Move()
    {
        Debug.Log("Movimiento teclado");
    }
    public void Attack()
    {
        Debug.Log("Ataque teclado");
    }
}
