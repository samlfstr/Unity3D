using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TriangleCreator : MonoBehaviour {



    public Transform waypoints;
    
    void OnDrawGizmos()
    {
        Vector3 startPos = waypoints.GetChild(0).transform.position;
        Vector3 nextPos = startPos;
        foreach(Transform waypoint in waypoints)
        {
            Gizmos.DrawSphere(waypoint.position,.3f);
            Gizmos.DrawLine(nextPos,waypoint.position);
            nextPos=waypoint.position;
        }
            Gizmos.DrawLine(nextPos,startPos);
       
    }
    void Update()
    {


        

    }








}
