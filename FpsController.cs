using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FpsController : MonoBehaviour {

    public GameObject eyes;

    float vitess = 5f;
   
    Rigidbody player;

    float moveA;
    float moveB;
    float rotA;
    float rotB;

    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {


        // pk raw parce qu'on veux pas que cela ait une lissage par défaut
        moveA = Input.GetAxisRaw("Horizontal");
        moveB = Input.GetAxisRaw("Vertical");
        rotA = Input.GetAxis("Mouse X") * vitess;
        rotB = Input.GetAxis("Mouse Y") * vitess;


        // les coordonnées
        Vector3 mouveInput = new Vector3(moveB, 0, -moveA) * vitess;
        Vector3 Velocity = mouveInput.normalized * vitess;
        transform.Rotate(0, rotA, 0, Space.World);
        eyes.transform.Rotate(-rotB, 0, 0);

        Vector3 newPosition = player.position + transform.TransformDirection(Velocity * Time.deltaTime);
        player.MovePosition(newPosition);

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            SpeedMove();
        }
        else
        {
            vitess = 5f;
        }
    }


    void SpeedMove()
    {
        vitess = 10f;
    }



}
