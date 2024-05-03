using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject tutorialParent;
    void Awake()
    {
        if (PlayerPrefs.GetInt("tutorialUsed", 1) == 1) 
        {
            tutorialParent.SetActive(true);
            PlayerPrefs.SetInt("tutorialUsed", 0);
            PlayerPrefs.Save(); 
        }
        else 
        {
            tutorialParent.SetActive(false);
        }


        
    }

    void ActivationTest()
    {
        
    }
    public void ButtonPressed()
    {
        if (tutorialParent.activeSelf == false) tutorialParent.SetActive(true); else tutorialParent.SetActive(false);
    }
}
