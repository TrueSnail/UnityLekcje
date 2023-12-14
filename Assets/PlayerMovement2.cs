using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovement2 : MonoBehaviour
{
    //Niedzia�aj�cy skrypt u�ywaj�cy nowego input systemu, poprawi� go na nast�pne zaj�cia

    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void PlayerMove(CallbackContext context)
    {
        rb.AddForce(context.ReadValue<Vector2>() * 10);
    }
}
