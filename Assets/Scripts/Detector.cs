using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Detector : MonoBehaviour
{
    public GameObject btn;
    Text txt;
    public void TestFunct()
    {
        print("hi");
    }

    public void TextColorBlack(){
        txt = btn.transform.GetChild(0).GetComponent<Text>();
        txt.color = Color.black;
    }

    public void TextColorWhite(){
    txt = btn.transform.GetChild(0).GetComponent<Text>();
    txt.color = Color.white;
}

   /* public void OnPointerEnter(PointerEventData eventData)
    {
        print("On Button");
       // HandleText(btn, Color.black);
    }
    
 /*   void OnMouseExit()
    {
        print("Off Button");
        HandleText(btn, Color.white);
    }*/
}
