using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationWithArrays : MonoBehaviour {
    
    public GameObject[] addcubes;
    public GameObject cubes;
    public float distance;
    public float timer;
    string Nameof;
    int inc;
    int i;
    void Start () {
        i=1;
        inc=0;
        cubes.name=("cube0");
      
        InvokeRepeating("cubeCreator",0,timer);
    }

    void Update () { }

    void cubeCreator(){

        Instantiate(cubes,new Vector3(0,0,0+distance),Quaternion.identity);
        cubes.name=("cube"+i);
        Debug.Log(cubes.name);
        addcubes[inc]=cubes;
        i++;
        inc++;
        distance+=1f;
    }




}
