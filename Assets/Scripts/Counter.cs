using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public GameObject[] coin;

    public TextMeshProUGUI textCoins;

    public int coins;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            coin[].SetActive(false);
            coins++;
        }
    }
    private void Update()
    {
        textCoins.text = "Coins: " + coins.ToString();
        Debug.Log(coins);
    }
}
