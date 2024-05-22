using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject DarkMode;
    public GameObject DarkBackground;
    public GameObject DarkSettings;
    public Slider DarkSlider;
    public GameObject LightMode;
    public GameObject LightBackground;
    public GameObject LightSettings;
    public Slider LightSlider;
    public Vector3 scaleMinimum;
    public Vector3 scaleMaximum;
    public int ContrastToggle = 0;
    public bool reset = false;

    void Awake()
    {
        scaleMinimum = new Vector3(0f,0f,0f);
        scaleMaximum = new Vector3(1f,1f,1f);
        if (StoringValues.prefsSet==0)
        {
            PlayerPrefs.SetInt("ContrastToggle", 1);
            PlayerPrefs.SetInt("SettingsOpen", 0);
            StoringValues.prefsSet = 1;
        }
    }
    void Update()
    {
        //If the variable is 0 and the canvas is not already active, the dark mode canvas and background get set active
        if (PlayerPrefs.GetInt("ContrastToggle", 0) == 0 && (!DarkMode.activeSelf) )
        {
            DarkMode.SetActive(true);
            DarkBackground.SetActive(true);
            LightMode.SetActive(false);
            LightBackground.SetActive(false);
        }
        //If the variable is 1 and the canvas is already active, the dark mode canvas and background get set inactive
        else if (PlayerPrefs.GetInt("ContrastToggle", 0) == 1 && (DarkMode.activeSelf) )
        {
            DarkMode.SetActive(false);
            DarkBackground.SetActive(false);
            LightMode.SetActive(true);
            LightBackground.SetActive(true);
        }
        //If DarkSettings open bool is true and dark mode is active then open the dark mode settings
        if (PlayerPrefs.GetInt("SettingsOpen", 0) == 1 && (DarkMode.activeSelf) )
        {
            DarkSettings.SetActive(true);
            DarkSettings.transform.localScale = scaleMaximum;
            
        }
        //If DarkSettings open bool is false and dark mode is active then close the dark modes settings
        else if (PlayerPrefs.GetInt("SettingsOpen", 0) == 0 && (DarkSettings.activeSelf) )
        {
            DarkSettings.transform.localScale = scaleMinimum;
            DarkSettings.SetActive(false);
        }
        if (PlayerPrefs.GetInt("TextSize", 0)!=LightSlider.value || PlayerPrefs.GetInt("TextSize", 0)!=DarkSlider.value)
        {
            LightSlider.value = PlayerPrefs.GetInt("TextSize", 0);
            DarkSlider.value = PlayerPrefs.GetInt("TextSize", 0);
        }
        if (reset)
        {
            ResetPrefs();
            reset = false;
        }

    }

    void ResetPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
