using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerController
{
    public void Move();
    public void Attack();
}
public class Player : MonoBehaviour
{
    private IPlayerController controller;
    private KeyboardController keyboardController = new KeyboardController();
    private GamepadController gamepadController = new GamepadController();
   // [SerializeField] private bool usarGamepad = false;
    

    void Start()
    {
        //AsignarControlador();
        controller = keyboardController = new KeyboardController();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*usarGamepad = !usarGamepad;
            AsignarControlador();*/
            // dato = condicion ?  retorno A : RETORNO b;

            // controlador =    controlador == gamepadcontrol? keybord : gamepad;

            controller = controller == gamepadController ? keyboardController : gamepadController;
            Debug.Log(controller);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            controller?.Move();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            controller?.Attack();
        }
    }
    
    /*public void AsignarControlador()
    {
        if (usarGamepad)
        {
            controller = new GamepadController();
            Debug.Log("Controlador actual: Gamepad");
        }
        else
        {
            controller = new KeyboardController();
            Debug.Log("Controlador actual: Teclado");
        }
    }*/
}
