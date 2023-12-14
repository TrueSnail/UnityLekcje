using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizja : MonoBehaviour
{
    public GameObject OutOfBoundsCollider;
    Vector3 StartPosition;

    //Zapisywanie pocz¹tkowej pozycji obiektu do zmiennej
    void Start()
    {
        StartPosition = transform.position;
    }

    //Funkcja uruchamia siê przy kolizji z innym obiektem
    private void OnCollisionEnter(Collision collision)
    {
        //Sprawdzanie czy obiekt z którym ten dokona³ kolizji ma go cofn¹æ na pocz¹tek
        if(collision.gameObject == OutOfBoundsCollider)
        {
            //Resetowanie pozycji do startowej
            transform.position = StartPosition;
        }
    }
}
