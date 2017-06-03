using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BetterThanOnTriggerEnter : MonoBehaviour {

    public float distanceAllowed;
    public Transform other;

    Color defaultColor;
    Renderer cubeRen;
    
    void Start()
    {
        cubeRen=GetComponent<Renderer>();
        defaultColor=cubeRen.material.color;
    }

    void Update()
    {
        //(Distance between that object and the other object)
        Vector3 decalage = other.position-transform.position;
        // magnitude is simply sqrt(sqr(x) + sqr(y)) that's gonna give us the distance
        float decalageMag = decalage.magnitude;

        if(decalageMag<distanceAllowed)
            cubeRen.material.color=Color.red;
        else
            cubeRen.material.color=defaultColor;

    }

}
