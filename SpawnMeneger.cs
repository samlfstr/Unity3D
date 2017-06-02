using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeneger : MonoBehaviour {

    public GameObject FallingThinks;
    public float WaitSome = 0.5f;
    float nextSpawnTime;
    public Vector2 spawnSizeMinMax;
    public float spawnAng;

    

    Vector2 screenSize;


    
    void Start () {
        screenSize=new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);


    }
    
    void Update () {

        if(Time.time > nextSpawnTime)
        {
            nextSpawnTime=Time.time+WaitSome;

            float spawnSize = Random.Range(spawnSizeMinMax.x,spawnSizeMinMax.y);

            float spawnAngle = Random.Range(-spawnAng,spawnAng);

            Vector2 randomPositions = new Vector2(Random.Range(-screenSize.x, screenSize.x), screenSize.y + spawnSize);

            GameObject newBlock = (GameObject) Instantiate(FallingThinks,randomPositions,Quaternion.Euler(Vector3.forward * spawnAngle));

            newBlock.transform.localScale=Vector2.one*spawnSize;
        }



    }
}
