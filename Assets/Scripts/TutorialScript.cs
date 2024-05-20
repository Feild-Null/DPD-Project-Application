using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject darkTutorialParent;
    public GameObject lightTutorialParent;
    [SerializeField] private bool RESET_TUTORIAL = false;
    void Awake()
    {
        if (PlayerPrefs.GetInt("tutorialUsed", 1) == 1) 
        {
            if (PlayerPrefs.GetInt("ContrastToggle", 1) == 1)
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

    void Update()
    {
        if (RESET_TUTORIAL)
        {
            PlayerPrefs.SetInt("tutorialUsed", 1);
            PlayerPrefs.Save(); 
        }
    }
}
