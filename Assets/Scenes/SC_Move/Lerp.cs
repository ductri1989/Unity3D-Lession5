using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour{
    Vector3 target = new Vector3 (7, 0, 0);
    void Start(){
        transform.position = new Vector3(-7, 0, 0);
    }

    void Update(){
        transform.position = Vector3.Lerp(transform.position, target, 0.01f);
    }
}
