using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject darkTutorialParent;
    public GameObject lightTutorialParent;
    void Awake()
    {
        if (PlayerPrefs.GetInt("tutorialUsed", 1) == 1) 
        {
            if (PlayerPrefs.GetInt("ContrastToggle", 1) == 0)
            {
                darkTutorialParent.SetActive(true);
            } 
            else if (PlayerPrefs.GetInt("ContrastToggle", 1) == 1)
            {
                lightTutorialParent.SetActive(true);
            }
            PlayerPrefs.SetInt("tutorialUsed", 0);
            PlayerPrefs.Save(); 
        }
        else 
        {
            lightTutorialParent.SetActive(false);
            darkTutorialParent.SetActive(false);
        }


        
    }

    void ActivationTest()
    {
        
    }
    public void ButtonPressed()
    {
        if (PlayerPrefs.GetInt("ContrastToggle", 1) == 0)
        {
            if (darkTutorialParent.activeSelf == false) darkTutorialParent.SetActive(true); else darkTutorialParent.SetActive(false);
        } 
        else if (PlayerPrefs.GetInt("ContrastToggle", 1) == 1)
        {
            if (lightTutorialParent.activeSelf == false) lightTutorialParent.SetActive(true); else lightTutorialParent.SetActive(false);
        }
        
    }
}
