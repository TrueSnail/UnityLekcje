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

        //Sprawdzamy, kt�re przyciski gracz nacisn��
        bool forward = Input.GetKey(KeyCode.W);
        bool back = Input.GetKey(KeyCode.S);
        bool left = Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.D);

        //Modyfikujemy kierunek poruszania si� w zale�no�ci od wci�ni�cia przcisk�w
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

        //Dodajemy si�� do rigidbody by poruszy� gracza w odpowienim kierunku
        //Mno�ymy moveDirection przez MoveSpeed by umo�liwi� kontrol� pr�dko�ci
        rb.AddForce(moveDirection * MoveSpeed);
    }
}