using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTrigger : MonoBehaviour {

    public bool ObsContrl;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "PLAYER")
        {
            ObsContrl = true;
            Debug.Log("Player is inside");
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "PLAYER")
        {
            ObsContrl = false;
            Debug.Log("Player is outside");
        }

    }




}
