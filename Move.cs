using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 1f;
    bool stop = false;
    float screenWeight;

    void Start()
    {

        float halfOfThePlayer = transform.localScale.x/2f;
        screenWeight=Camera.main.aspect*Camera.main.orthographicSize+halfOfThePlayer;


    }

    void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            stop=!stop;
        }
        if(stop)
        {
            transform.Translate(Vector3.right*speed*Time.fixedDeltaTime);
        }
        if(stop != true)
        {
            transform.Translate(Vector3.left*speed*Time.fixedDeltaTime);
        }


        if(transform.position.x < -screenWeight)
        {
            transform.position=new Vector3(screenWeight, transform.position.y);

        }

        if(transform.position.x > screenWeight)
        {
            transform.position=new Vector3(-screenWeight,transform.position.y);

        }

    }
}
