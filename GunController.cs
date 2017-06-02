using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    float rotA;
    public float speed = 10f;
    public Transform muzzle;
    public Bullet bullet;


    void Start () {
        
    }

    void Update () {

        rotA=Input.GetAxis("Mouse X")*speed;
        transform.Rotate(0f, rotA, 0f, Space.World);

        if(Input.GetMouseButtonDown(0))
        {

          Bullet bllt;
          bllt=Instantiate(bullet, muzzle.position,muzzle.rotation) as Bullet;
        
        }

        Cursor.visible=false;



    }
}
