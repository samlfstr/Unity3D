using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    void OnEnable()
    {
        EventMeneger.OnClicked+=Teleportation;
    }
    void OnDisable()
    {
        EventMeneger.OnClicked-=Teleportation;
    }

   
    void Teleportation()
    {
        Vector3 pos = transform.position;
        pos.x=Random.Range(-3f,3f);
        transform.position=pos;
    }


}
