using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    public Vector3 scaleMinimum;
    public Vector3 scaleMaximum;
    public GameObject gameObject;

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
    }
}
