using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverText : MonoBehaviour {

    public float smoothness;
    public string textHolder;
    public Text myText;
    public bool displayInfos;

    void Start()
    {
        // name of the text
        myText=GameObject.Find("Arbre").GetComponent<Text>();
        myText.color=Color.clear;

        
    }
	

	void Update () {


        Palir();
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Cursor.lockState=0;
            Cursor.visible=true;
        }
    }

    void OnMouseOver()
    {
        displayInfos=true;
    }

    void OnMouseExit()
    {
        displayInfos=false;
    }

    void Palir()
    {
        if(displayInfos)
        {

            myText.text=textHolder;
            myText.color=Color.Lerp(myText.color,Color.white, smoothness * Time.fixedDeltaTime);

        }
        else
        {
            myText.color=Color.Lerp(myText.color,Color.clear,smoothness*Time.deltaTime);
        }


    }









}
