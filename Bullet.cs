using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {


  
	void Update () {

        transform.Translate(-2f,0f,0f);

        Destroy(gameObject, 1f);

	}
}
