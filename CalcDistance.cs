using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcDistance : MonoBehaviour {

    public Transform points;
    Vector3 pointA, pointB;
    float distanceValue;
    Vector3 distance;
    void Start()
    {
        
    }
    
    void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            calcDistance();
        }
       

    }

    public void calcDistance()
    {
        pointA=points.GetChild(0).position;
        pointB=points.GetChild(1).position;
        distanceValue=Vector3.Distance(pointA,pointB);
        Debug.Log(distanceValue);

    }
}
