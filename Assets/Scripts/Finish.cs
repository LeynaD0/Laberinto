using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject hudScreen;
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            winScreen.SetActive(true);
            hudScreen.SetActive(false);
        }
    }
}
