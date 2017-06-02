using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    float speed = 10f;
    float screenWide;
    public int[] difficulty = new int[3];

    void Start () {

        float halfoftheplayer = transform.localScale.x/2f;
        screenWide=Camera.main.aspect*Camera.main.orthographicSize+halfoftheplayer;

    }

    
    void Update () {


        float inputX = Input.GetAxisRaw("Horizontal");
        float velocity = inputX*speed;
        
        transform.Translate(Vector2.right * velocity * Time.deltaTime);
        transform.Translate(Input.acceleration.x * Time.deltaTime * speed*3,0,0);

        


        if(transform.position.x < -screenWide)
        {
            transform.position=new Vector2(screenWide, transform.position.y);
        }
        if(transform.position.x > screenWide)
        {
            transform.position=new Vector2(-screenWide,transform.position.y);
        }


        

    }

    void OnTriggerEnter2D(Collider2D FallingBlocks) {
        /*
        if(FallingBlocks.tag =="RedCube")
        {
            FindObjectOfType<UIGameOver>().increaseCubeNumber();
        }
         */



       
        if(FallingBlocks.tag == "Fall")
        {
           
            Destroy(gameObject);
            FindObjectOfType<UIGameOver>().setActive();
        }
        
     
    }

  
}
