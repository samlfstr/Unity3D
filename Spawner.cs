using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {


    public GameObject[] ennemies;                    // Ennemys
    public Vector3 spawnValues;                      // Position of the annemys
                                                     
    public float spawnWait;                          // Time
    public float spawnMinWait;                       // Time
    public float spawnMaxWait;                       // Time
    public int startWait;                            // Time

    public bool stop;                                // For stop the loop
                                                     
    int randEnemy;                                   // Random values
                                                     
                                                     
	// Use this for initialization                   
	void Start () {

        StartCoroutine(WaitSpawner());                                 
	}                                                
	                                                 
	// Update is called once per frame               
	void Update () {

        spawnWait=Random.Range(spawnMinWait, spawnMaxWait);                               
	}                                                
                                                     
    IEnumerator WaitSpawner()                        
    {                                                
        yield return new WaitForSeconds(startWait);  
                                                     
        while(!stop)                                 
        {                                            
            // random between 0 and 1                
            randEnemy=Random.Range(0,2);             
                                                     
            // spawn position                        
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x ), 1,Random.Range(-spawnValues.z,spawnValues.z));

            Instantiate(ennemies[randEnemy],spawnPosition + transform.TransformPoint(0,0,0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);

        }

    }





}

