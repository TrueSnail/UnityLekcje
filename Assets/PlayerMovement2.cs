using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovement2 : MonoBehaviour
{
    //Niedzia³aj¹cy skrypt u¿ywaj¹cy nowego input systemu, poprawiê go na nastêpne zajêcia

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
