using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    [SerializeField]
    Material materialLightBlue; //Material base que tienen las paredes.

    [SerializeField]
    Material materialRed; // Material que se pone al chocar con el jugador.

    bool wallred = false;
    float timered = 2f;

    //En el "Update" le estamos diciendo que si este es verdadero, se activa un tiempo para que cambie nuevamente de color, y si este llega a 0, el material cambia al color base, la condición "bool" vuelve a ser falsa y su tiempo se reinicia.
    private void Update()
    {
        if (wallred == true)
        {
            timered = timered - Time.deltaTime;

            if(timered < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialLightBlue;
                wallred = false;
                timered = 5f;
            }
        }
    }

    //Función que se ejecuta al chocar con una pared.
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = materialRed;
            wallred = true;
        }
    }
}
