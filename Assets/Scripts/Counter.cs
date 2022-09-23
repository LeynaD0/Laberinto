using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public GameObject coin;

    public TextMeshProUGUI textCoins;

    public float coins;

    bool coinActive = true;

    private void Start()
    {
        coins.ToString("0");
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            coinActive = false;
            //coins += 1f;
        }
    }
    private void Update()
    {
        if(coinActive == false)
        {
            coins++;
            coin.SetActive(false);
            textCoins.text = "Coins: " + coins.ToString();
        }
        
    }
}
