using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    public Vector3 scaleMinimum;
    public Vector3 scaleMaximum;
    public GameObject gameObject;
    public int TextSize = 30;
    public bool HighContrastMode = false;
    public GameObject[] TextSizes;

    // Start is called before the first frame update
    void Awake()
    {
        scaleMinimum = new Vector3(0f,0f,0f);
        scaleMaximum = new Vector3(1f,1f,1f);
        if (gameObject != null)
        {
            gameObject.transform.localScale = scaleMinimum;
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ButtonPressed(GameObject button)
    {
        if (button.name == "SettingsButton")
        {
            gameObject.SetActive(true);
            gameObject.transform.localScale = scaleMaximum;
        }
        if (button.name == "BackButtonSettings")
        {
            gameObject.transform.localScale = scaleMaximum;
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
    public void OnSliderChanged(float value) 
    {
        // TextSize = value.ToInt();
        // for (int i = 0; i < TextSizes.len; i++)
        // {
        //     TextSizes[i].Font.fontSize = TextSize;
        // }
    }

}