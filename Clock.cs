using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

    public float second;
    public float angle;
    public float angle2;

    void Start()
    {
        second=1;
        StartCoroutine(ClockTime());
    }



    void Update()
    {
        Vector3 direction = new Vector3(Mathf.Sin(angle* Mathf.Deg2Rad),0,Mathf.Cos(angle* Mathf.Deg2Rad));
        Debug.DrawRay(transform.position,direction * 3,Color.red);
        Vector3 direction2 = new Vector3(Mathf.Sin(angle2*Mathf.Deg2Rad),0,Mathf.Cos(angle2*Mathf.Deg2Rad));
        Debug.DrawRay(transform.position,direction2*2,Color.yellow);

    }

    IEnumerator ClockTime()
    {
        while(true)
        {
            angle=angle+6;
            if(angle>354)
            {
                angle=0;
                angle2+=6;
                if(angle2 > 354)
                {
                    angle2=0;
                }

            }
            if(angle < -354)
            {
                angle=0;
                angle2-=6;
            }
            yield return new WaitForSeconds(second);
        } 
    }



}
