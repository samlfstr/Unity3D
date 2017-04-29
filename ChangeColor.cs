using System;
using UnityEngine;
using UnityEngine.EventSystems;

// On utilise les interface qui commence toujour avec l'initial de I
public class ChangeColor : MonoBehaviour,IPointerClickHandler {
    
    public float fallingSpeed;

    public Renderer cubeRenderer;
    public Color cubeSpecifiColor;
    private Color cubeColor;
    private Color[] colors = new Color[6];

    
    
    void Start () {
        
        //Color = Renderer.material.color
        cubeColor=cubeRenderer.material.color;

        // change between 6 colors
        
        colors[0]=Color.black;
        colors[1]=Color.red;
        colors[2]=Color.blue;
        colors[3]=Color.red;
        colors[4]=Color.yellow;
        colors[5]=Color.magenta;


    }

    void Update () {
        // Falling Objects
        transform.Translate(Vector3.back * fallingSpeed * Time.fixedDeltaTime);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
      
        cubeRenderer.material.color=colors[UnityEngine.Random.Range(0,6)];
    }

    
}
