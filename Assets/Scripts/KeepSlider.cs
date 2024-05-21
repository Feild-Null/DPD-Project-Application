using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepSlider : MonoBehaviour
{
    public Slider mainSlider;
    public Slider nightSlider;
 
    void Awake()
    {
        mainSlider.value = PlayerPrefs.GetInt("TextSize", 29);
        nightSlider.value = PlayerPrefs.GetInt("TextSize", 29);
    }
}
