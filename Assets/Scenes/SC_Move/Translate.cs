using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(-7, 3, 0);
    }

    void Update()
    {
        transform.Translate(0.01f,0,0);
    }
}
