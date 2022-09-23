using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    [SerializeField]
    Material materialLightBlue;

    [SerializeField]
    Material materialRed;

    bool wallred = false;
    float timered = 2f;

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
