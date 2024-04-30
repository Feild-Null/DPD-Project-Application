using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject tutorialParent;
    void Start()
    {
        tutorialParent.SetActive(false);
    }

    void ActivationTest()
    {
        
    }
    public void ButtonPressed()
    {
        if (tutorialParent.activeSelf == false) tutorialParent.SetActive(true); else tutorialParent.SetActive(false);
    }
}
