using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    public float XMouseSpeed;
    public float YMouseSpeed;
    public GameObject camera;
    public GameObject bullet;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
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
            moveDirection += transform.forward;
        }
        if(back)
        {
            moveDirection += -transform.forward;
        }
        if (left)
        {
            moveDirection += -transform.right;

        }
        if (right)
        {
            moveDirection += transform.right;
        }

        //Dodajemy si³ê do rigidbody by poruszyæ gracza w odpowienim kierunku
        //Mno¿ymy moveDirection przez MoveSpeed by umo¿liwiæ kontrolê prêdkoœci
        //rb.AddForce(moveDirection * MoveSpeed);
        rb.velocity = new Vector3(moveDirection.x * MoveSpeed, rb.velocity.y, moveDirection.z * MoveSpeed);

        var x = Input.GetAxis("Mouse X") * XMouseSpeed;
        var y = -Input.GetAxis("Mouse Y") * YMouseSpeed;

        camera.transform.Rotate(Vector3.right, y);
        transform.Rotate(Vector3.up, x);


        bool mousePressed = Input.GetMouseButton(0);
        if (mousePressed)
        {
            var shoot = Instantiate(bullet, camera.transform.position, camera.transform.rotation);
            shoot.GetComponent<Rigidbody>().velocity = camera.transform.forward * 100;
        }
    }
}