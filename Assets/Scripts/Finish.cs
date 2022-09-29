using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Finish : MonoBehaviour
{
    public GameObject winScreen;  //Canvas que aparece al finalizar el recorrido del Laberinto.
    public TextMeshProUGUI textTime;  //Donde mostrara el tiempo.

    float tiempoPartida = 0.0f;
    bool estaJugando = true;  

    //Si se encuentra jugando el jugador, el tiempo avanzara.
    private void Update()
    {
        if(estaJugando == true)
        {
            tiempoPartida = tiempoPartida + Time.deltaTime;
        }
    }

    //Al entrar el jugador, activa el canvas que nos muestra la pantalla "ganaste", desactiva el movimiento del jugador, la condición sera falsa y mostrara el tiempo que se obtuvo.
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            winScreen.SetActive(true);
            other.GetComponent<Movement>().enabled = false;
            estaJugando = false;
            textTime.text = "Tiempo: " + tiempoPartida.ToString();
        }
    }
}
