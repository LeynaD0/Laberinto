using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHorizontal : MonoBehaviour
{
    [SerializeField]

    float puntoA;

    [SerializeField]
    float puntoB;


    void Update()
    {
        if(transform.position.x > puntoA)
        {
            transform.position += new Vector3(puntoB * Time.deltaTime, 0, 0);
        }

        if (transform.position.x < puntoB)
        {
            transform.position -= new Vector3(puntoA * Time.deltaTime, 0, 0);
        }
    }
}
