using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizja : MonoBehaviour
{
    public GameObject OutOfBoundsCollider;
    Vector3 StartPosition;

    //Zapisywanie pocz�tkowej pozycji obiektu do zmiennej
    void Start()
    {
        StartPosition = transform.position;
    }

    //Funkcja uruchamia si� przy kolizji z innym obiektem
    private void OnCollisionEnter(Collision collision)
    {
        //Sprawdzanie czy obiekt z kt�rym ten dokona� kolizji ma go cofn�� na pocz�tek
        if(collision.gameObject == OutOfBoundsCollider)
        {
            //Resetowanie pozycji do startowej
            transform.position = StartPosition;
        }
    }
}
