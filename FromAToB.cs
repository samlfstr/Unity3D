using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FromAToB : MonoBehaviour {

    public Transform A, B;

    public float speed = 1f;
    public bool key;
    float distance;
    Vector3 direction;
    // Double click
    float dclick_threshold = 0.25f;
    double timerdclick = 0;

    void Start()
    {
        speed=speed*Time.fixedDeltaTime; // float
        key=false; // bool
        transform.position=A.position; // vector3
        distance=B.position.x-A.position.x; // float
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            key=!key;
        }
        if(key)
        {
            fromAtoB();
            
        }
        else
        {
            fromBtoA();
           
        }

        // Explication si le temp qui est passé apres premier click est plus cours que la duré
        // Fixé alors double click faite


        // Double click
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
           
            // Wait 0.25 seconds before 
            
            if((Time.time-timerdclick)>dclick_threshold)
            {
                //call the SingleClick() function, not shown
            } 
            else{
                //call the DoubleClick() function, not shown
                transform.Translate(Vector3.up * 5);
            }
            // Updated Time.time 
            timerdclick=Time.time;
        }






    }

    void fromAtoB() {
        transform.position=Vector3.Lerp(transform.position,B.position, speed);
    }
    void fromBtoA() {
        if(transform.position != A.position)
        {
            transform.position=Vector3.Lerp(transform.position, A.position, speed);
        }
    }








}
