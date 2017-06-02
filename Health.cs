using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
        int healt = 0;
    public GameObject explosionEffect;
        void OnTriggerEnter(Collider other) {
          if(other.transform.tag == "Player")
          {
             healt=healt+1;
             Debug.Log("meeerd");
             
          }

          if(healt >= 3)
          {
            Vector3 newPosition = transform.position;
            Instantiate(explosionEffect,newPosition, Quaternion.identity);
            Destroy(this.gameObject,0.5f);
          }

        }
}





