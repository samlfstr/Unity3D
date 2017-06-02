using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAroundACenter : MonoBehaviour {


    public Vector2 tournotour;

    void Start() {
       
    }



    void Update()
    {
        transform.RotateAround(tournotour,Vector3.up,-500*Time.fixedDeltaTime);
       
    }
    


}
