using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cam : MonoBehaviour
{ 
    public Camera A;
    public Camera B;

    // Use this for initialization
    void Start()
    {
        A = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.H))
        {
          if (B.enabled == true)
          {
              B.enabled = false;
              
          }
        }
  

    }
}
