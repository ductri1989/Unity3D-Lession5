using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quai : MonoBehaviour{
    [SerializeField] Transform postA, postB;
    Vector3 target;
    
    void Start()
    {
        transform.position = postA.position;
        transform.DOMove(postB.position, 5);
    }


    void Update(){
        if(transform.position == postA.position) { 
            transform.DOMove(postB.position, 5);
            transform.Rotate(Vector3.up, 180);
        }

        if (transform.position == postB.position) {
            transform.DOMove(postA.position, 5);
            transform.Rotate(Vector3.up, 180);
        }

    }
}
