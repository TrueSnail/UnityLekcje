using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mruganie : MonoBehaviour
{
    public float speed; //Cz�stotliwo�� mrugania
    Light lightComponent; //Referencja do komponentu Light
    float time; //Czas od startu gry * Cz�stotliwo��

    void Start()
    {
        //Pobieramy komponent light z tego obiektu
        lightComponent = GetComponent<Light>();
    }

    void Update()
    {
        //Zmieniamy intensywno�� �wiat�a
        lightComponent.intensity = Mathf.Sin(time);
        //Zwi�kszamy zmienn� by w nast�pnej klatce pobra� nast�pn� warto�� sinusa
        //Time.deltaTime daje nam czas od stworzenia poprzedniej klatki, mno�ymy to przez zmienn� speed by m�c edytowa� pr�dko�� zmiany sinusa
        time += Time.deltaTime * speed;
    }
}
