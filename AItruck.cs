using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AItruck : MonoBehaviour {

    NavMeshAgent newEnnemy;
    Transform target;
    public float StartWait;
    public float Duration;
    Vector3 newposition;
    bool stop = false;

    
    void Start () {
        newEnnemy=GetComponent<NavMeshAgent>();
        target=GameObject.FindGameObjectWithTag("Player").transform;
        
        StartCoroutine(waitSome());
        newposition=target.position;
        
    }
    
    // Update is called once per frame
    void Update () {

        newEnnemy.SetDestination(newposition);
      

    }
    IEnumerator waitSome()
    {
        // start wait
        yield return new WaitForSeconds(StartWait);

        while(!stop)
        {
           newposition = target.position;
           // new wait duration
           yield return new WaitForSeconds(Duration);
        }
    }








}
