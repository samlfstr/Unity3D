using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalingBlocks : MonoBehaviour {

    public float speed = 7f;
    void Start()
    {
        
        StartCoroutine(DifficultyIncrease());
    }

    void Update() {


        transform.Translate(Vector2.down*speed*Time.fixedDeltaTime);
        Destroy(this.gameObject,1.75f);
  

    }

    IEnumerator DifficultyIncrease()
    {
        if(Time.timeSinceLevelLoad> 30 && Time.timeSinceLevelLoad<45 )
        {
            yield return 10;
            speed=10f;

        }
        if((Time.timeSinceLevelLoad>45&&Time.timeSinceLevelLoad<90))
        {
            yield return 20;
            speed=15f;
        }
        if(Time.timeSinceLevelLoad>90)
        {
            yield return 30;
            speed=30f;
        }

    }
}
