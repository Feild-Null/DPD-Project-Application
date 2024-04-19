using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Text _sliderText;
    float cool = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // slider.onValueChanged.AddListener((v) =>{
        //     _sliderText.text = v.toString("0.00");
        // });

        //print(cool.toString("5"));
    }
}
