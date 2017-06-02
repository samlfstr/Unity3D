using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float vitess = 4f;
    void Update () {

        transform.Translate(Vector3.forward * vitess,Space.Self);
        Destroy(this.gameObject, 1.5f);

    }
}
