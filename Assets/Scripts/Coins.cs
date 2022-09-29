using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class Coins : MonoBehaviour
{
    //El transform.Rotate es para rotar un objeto de manera continua si este esta situado en el "Update".
    private void Update()
    {
        transform.Rotate(0.0f, 70 * Time.deltaTime, 0f);
    }


}
