using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour{
    public GameObject dart;

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            Instantiate(dart, transform.position, Quaternion.identity);
        }
    }
}