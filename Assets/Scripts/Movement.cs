using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float movimientoejey;
    public float movimientoejex;
    public float movimientoejez;

    public float speed = 1.5f;
    void Start()
    {
        //Cuando algo esta entre dos comillas, es un "string", que es un mensaje de texto.
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoejez = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        movimientoejex = - Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(movimientoejex, movimientoejey, movimientoejez);

    }
}
