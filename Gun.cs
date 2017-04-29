using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public Transform muzzle;
    public BulletController bullet;
    public float waitDuration;
    float nextShootTime;
    public static bool stopit;
    
    void Start()
    {

    }

    void Update()
    {
        Ray rayon = new Ray(transform.position,transform.forward);

        RaycastHit hitInfo;


        if(Physics.Raycast(rayon,out hitInfo,15f))
        {
            Debug.DrawLine(transform.position,hitInfo.point,Color.red);
            stopit=true;
          
        }
        else
        {
            Debug.DrawLine(transform.position,transform.forward*100f,Color.green);
            stopit=false;

        }
        if((stopit==true) && (Time.time > nextShootTime))
        {
            nextShootTime=Time.time+waitDuration;
            Instantiate(bullet,muzzle.position,muzzle.rotation);
        }

    }




}
