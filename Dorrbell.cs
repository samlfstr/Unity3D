using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dorrbell : MonoBehaviour {

    #region Variables
    public bool control;
    public Light _light;
    public Animator DoorAnim;
    #endregion

    void Start()
    {
        DoorAnim.enabled = false;
    }

    void Update()
    {

        #region control

        if (control == true)
        {
            _light.enabled = true;
            DoorAnim.enabled = true;
        }
        else
        {
            _light.enabled = false;
        }
        #endregion
       
    }

    #region fontions

    void OnTriggerEnter(Collider other) {
        if (other.transform.name=="player")
        {
            control = true;
        }
       
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "player")
        {
            control = false;
        }

    }
    #endregion





}
