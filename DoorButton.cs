using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoorButton : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler  {


    public Renderer doorRendrer;
    public Color higlightedColor;

    private Color doorColor;

    void Start () {
        GetComponent<Animator>().enabled=false;
        doorColor=doorRendrer.material.color;

    }



    public void OnPointerEnter(PointerEventData eventData)
    {
        doorRendrer.material.color=higlightedColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        doorRendrer.material.color=doorColor;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GetComponent<Animator>().enabled=true;
    }
}
