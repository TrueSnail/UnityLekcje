using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 moveDirection = new Vector3();

        //Sprawdzamy, które przyciski gracz nacisn¹³
        bool forward = Input.GetKey(KeyCode.W);
        bool back = Input.GetKey(KeyCode.S);
        bool left = Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.D);

        //Modyfikujemy kierunek poruszania siê w zale¿noœci od wciœniêcia przcisków
        if(forward)
        {
            moveDirection.z = 1;
        }
        if(back)
        {
            moveDirection.z = -1;
        }
        if (left)
        {
            moveDirection.x = -1;

        }
        if (right)
        {
            moveDirection.x = 1;
        }

        //Dodajemy si³ê do rigidbody by poruszyæ gracza w odpowienim kierunku
        //Mno¿ymy moveDirection przez MoveSpeed by umo¿liwiæ kontrolê prêdkoœci
        rb.AddForce(moveDirection * MoveSpeed);
    }
}