using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float movimientoejey;
    public float movimientoejex;
    public float movimientoejez;

    public TextMeshProUGUI coinsText;
    int coinPoints;

    public float speed = 1.5f;
    
    //Para que el jugador se mueva con las teclas, para cambiar de dirección, se le pone un "-" después del igual.
    void Update()
    {
        movimientoejez = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        movimientoejex = - Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(movimientoejex, movimientoejey, movimientoejez);
    }

    //Al tocar una moneda, este hace que "desaparezca", te sume puntos y sea mostrado en la pantalla de "Ganaste".
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            collision.gameObject.SetActive(false);
            coinPoints++;
            Debug.Log(coinPoints);
            coinsText.text = "Coins: " + coinPoints.ToString();
        }
    }
}
