using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    [SerializeField]

    float rotation = 100f;
    void Update()
    {
        transform.Rotate(0.0f, rotation * Time.deltaTime, 0f);
    }
}
