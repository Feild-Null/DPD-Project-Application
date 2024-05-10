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
    Image img;

    void Start()
    {
    print(btn.transform.childCount);
    }




    public void TextColorBlack(){
       // print("text color black triggered");

        for (int i = 0; i < btn.transform.childCount; i++)
        {
            //print("loop triggered");
            if (btn.transform.GetChild(i).GetComponent<Text>()){
                txt = btn.transform.GetChild(i).GetComponent<Text>();
                txt.color = Color.black;
            }
        }
    }

    public void TextColorWhite(){
        for (int i = 0; i < btn.transform.childCount; i++)
        {
            if (btn.transform.GetChild(i).GetComponent<Text>()){
                txt = btn.transform.GetChild(i).GetComponent<Text>();
                txt.color = Color.white;
            }
        }
    }

    public void IconColorWhite(){
        print("icon color white triggered");
        for (int i = 0; i < btn.transform.childCount; i++)
        {
            print("loop triggered");
            if (btn.transform.GetChild(i).GetComponent<Image>()){
                print("img found");
                img = btn.transform.GetChild(i).GetComponent<Image>();
                img.color = Color.black;
            }
        }
    }

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

