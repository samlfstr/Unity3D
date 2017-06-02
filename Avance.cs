using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avance : MonoBehaviour {

    float speed = 1;
    // Use this for initialization
    void Start () {
        speed=speed*Time.deltaTime;
    }
    
    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.forward * speed, Space.World);
    }
}
