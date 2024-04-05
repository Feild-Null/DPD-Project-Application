using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScriptPrivateProperty : MonoBehaviour
{
    public TMP_Text MainText;
    public GameObject YesButton;
    public GameObject NoButton;

    [SerializeField] int index1 = 0;
    [SerializeField] int index2 = 0;
    public string[,] Options = {
    
        {//0
            "Does the suspect have a Prohibited Weapon?",
            "Does the suspect have a Prohibited Weapon?"
        },
        {//1
            "46.05 Felony 3",
            "Are they an Occupant / Property Owner"
        },
        {//2
            "Do they have a prior felony conviction? ",
            "They are a Guest \n 46.02 (a-5) Displaying a handgun in plain view in a Public Place & 46.02 (a-6) Carrying a handgun while intoxicated in a Public Place do not apply because being in a Public Place is an element of both offenses. Otherwise, treat guests as you would in a Public Place."
        },
        {//3
            "Conviction is within the last five years",
            "Do they have a Prior M/A Family Violence Conviction"
        },
        {//4
            "46.04 (a)(1) Felony 3",
            "No Offense"
        },
        {//5
            //The next two are after "Do they have a Prior M/A Family Violence Conviction"
            "Conviction is within the last five years",
            "No Offense"
        },
        {//6
            "46.04 (2)(b) Misdemeanor A",
            "No Offense"
        }
    };
    void Start()
    {
        MainText.text = Options[index1,index2];
    }
    public void ButtonPressed(GameObject button)
    {
    
        if(button.name == "YesButton" && (index1 == 3 && index2 == 1))
        {
            index1 = 5;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "YesButton")
        {
            index1 += 1;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        if(button.name == "NoButton" && (index1 == 3 && index2 == 1))
        {
            index1 = 5;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "NoButton")
        {
            index1 += 1;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        if((index1 == 1 && index2 == 0)||(index1 == 2 && index2 == 1)||(index1 == 4 && index2 == 1)||(index1==4&&index2==0)||(index1==6)||(index1==5&&index2==1))
        {
            YesButton.SetActive(false);
            NoButton.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
