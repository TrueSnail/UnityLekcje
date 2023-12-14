using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mruganie : MonoBehaviour
{
    public float speed; //Czêstotliwoœæ mrugania
    Light lightComponent; //Referencja do komponentu Light
    float time; //Czas od startu gry * Czêstotliwoœæ

    void Start()
    {
        //Pobieramy komponent light z tego obiektu
        lightComponent = GetComponent<Light>();
    }

    void Update()
    {
        //Zmieniamy intensywnoœæ œwiat³a
        lightComponent.intensity = Mathf.Sin(time);
        //Zwiêkszamy zmienn¹ by w nastêpnej klatce pobraæ nastêpn¹ wartoœæ sinusa
        //Time.deltaTime daje nam czas od stworzenia poprzedniej klatki, mno¿ymy to przez zmienn¹ speed by móc edytowaæ prêdkoœæ zmiany sinusa
        time += Time.deltaTime * speed;
    }
}
