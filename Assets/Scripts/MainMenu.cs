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
    
        if(button.name == "TrafficButton")
        {
            SceneManager.LoadScene(0);
        }
        else if(button.name == "ProhibitedButton")
        {
            SceneManager.LoadScene(5);
        }
        else if(button.name == "PublicButton")
        {
            SceneManager.LoadScene(3);
        }
        else if(button.name == "PrivateButton")
        {
            SceneManager.LoadScene(2);
        }
        //The places where the path ends
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
//Change