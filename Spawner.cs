using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {


    public GameObject cube;
    float screenWidth;
    float halfOfThePlayer;



	void Start () {

        halfOfThePlayer=gameObject.transform.localScale.x/2;
        screenWidth=Camera.main.aspect*Camera.main.orthographicSize;

	}
    
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cube, new Vector3(Random.Range(-screenWidth,screenWidth),0,10),Quaternion.Euler(0,45,0));
        }


	}
}
