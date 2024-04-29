using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    public Vector3 scaleMinimum;
    public Vector3 scaleMaximum;
    public GameObject gameObject;
    public int TextSize = 30;
    public Scene scene;
    public bool HighContrastMode = false;
    public GameObject[] TextSizes;

    
    void Awake()
    {
        //initializing variables
        scaleMinimum = new Vector3(0f,0f,0f);
        scaleMaximum = new Vector3(1f,1f,1f);

        //Sets text sizes of all objects when scene is changed
        TextSizes = GameObject.FindGameObjectsWithTag("Text");
        
        // setting the settings panel to inactive.
        if (gameObject != null)
        {
            gameObject.transform.localScale = scaleMinimum;
            gameObject.SetActive(false);
        }

        // finishing adjusting text sizes
        TextSize = PlayerPrefs.GetInt("TextSize", 0);
        //code in progress/doesn't work.
        // if (scene.name == "MainMenu" && TextSize >= 39)
        // {
        //     PlayerPrefs.SetInt("TextSize", 39);
        // }
        // TextSize = PlayerPrefs.GetInt("TextSize", 0);
        OnSliderChanged((float) TextSize);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("TextSize", TextSize);
        PlayerPrefs.Save();
    }

    // Determine what happens when a button is pressed.
    public void ButtonPressed(GameObject button)
    {
        if (button.name == "SettingsButton")
        {
            gameObject.SetActive(true);
            gameObject.transform.localScale = scaleMaximum;
        }
        if (button.name == "BackButtonSettings")
        {
            gameObject.transform.localScale = scaleMinimum;
            gameObject.SetActive(false);
        }
        if (button.name == "Quit") 
        {
            print("Are you sure you want to quit?");
            Application.Quit();
        }
        if (button.name == "HighContrastModeToggle")
        {
            if (HighContrastMode) HighContrastMode = false; else HighContrastMode = true;
        }
    }

    // Edits font size based on slider input.
    public void OnSliderChanged(float value) 
    {
        TextSize = (int) value;

        for (int i = 0; i < TextSizes.Length; i++)
        {
            TextSizes[i].GetComponent<Text>().fontSize = TextSize;
        }
    }

}