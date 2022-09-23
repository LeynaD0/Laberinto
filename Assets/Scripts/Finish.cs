using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Finish : MonoBehaviour
{
    public GameObject winScreen;
    public TextMeshProUGUI textTime;

    float tiempoPartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if(estaJugando == true)
        {
            tiempoPartida = tiempoPartida + Time.deltaTime;
        }
    }
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
