using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fontsizer : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    private void UpdateTextSize(int size)
    {
        text.fontSize = size;
    }
}
