using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Plane : MonoBehaviour {

    bool control;


    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name=="player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
        }
     
    }

    

}
