using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepSlider : MonoBehaviour
{
    public Slider sliderOne;
 
    void Awake()
    {
        sliderOne.value = PlayerPrefs.GetInt("TextSize", 0);
    }
}
