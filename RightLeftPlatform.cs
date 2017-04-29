using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLeftPlatform : MonoBehaviour {

    private Vector3 startPosition;
    private int speed;
    public float Distance;

    void Start () {
        startPosition=transform.position;
        speed=1;
    }

    void Update () {

        transform.position=new Vector3(startPosition.x+Distance*Mathf.Sin(Time.time*speed),transform.position.y,startPosition.z);
        transform.Translate(Vector3.back*1f);
       
    }
}
