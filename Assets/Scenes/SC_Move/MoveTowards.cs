using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveTowards : MonoBehaviour
{
    Vector3 target = new Vector3(7, 1.5f, 0);
    void Start(){
        transform.position = new Vector3(-7, 1.5f, 0);
    }

    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, target, 0.01f);
    }
}
