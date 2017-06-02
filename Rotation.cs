using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotation : MonoBehaviour {

    // referance
    public Transform sphereTransform;

	// Use this for initialization
	void Start () {
        sphereTransform.parent = transform;
	}
	
	// Update is called once per frame
	void Update () {

        //  transform.eulerAngles += new Vector3(0,180,0) * Time.deltaTime;
        transform.eulerAngles += Vector3.up * 180 * Time.deltaTime;

	}
}
