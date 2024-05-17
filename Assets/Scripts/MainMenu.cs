using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject TrafficButton;
    public GameObject ProhibitedButton;
    public GameObject PublicButton;
    public GameObject PrivateButton;
    // list of possible outputs
    
    void Start()
    {
    }
    public void ButtonPressed(GameObject button)
    {
        // reset all indexes to start to solve errors.
        StoringValues.valueToKeep=0;
        StoringValues.valueToKeep2=0;
        StoringValues.valueToKeep3=0;
        StoringValues.valueToKeep4=0;
        StoringValues.valueToKeep5=0;
        StoringValues.valueToKeep6=0;
        StoringValues.valueToKeep7=0;
        StoringValues.valueToKeep8=0;

        if(button.name == "TrafficButton")
        {
            SceneManager.LoadScene(2);
        }
        else if(button.name == "PublicButton")
        {
            SceneManager.LoadScene(4);
        }
        else if(button.name == "PrivateButton")
        {
            SceneManager.LoadScene(3);
        }
        //The places where the path ends
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
//Change