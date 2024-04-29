using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScriptPrivateProperty : MonoBehaviour
{
    public Text MainText;
    public GameObject YesButton;
    public GameObject NoButton;

    public static int PrivatePropertyIndex1=StoringValues.valueToKeep5;
    public static int PrivatePropertyIndex2=StoringValues.valueToKeep6;
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
    public void Awake()
    {
        PrivatePropertyIndex1=StoringValues.valueToKeep5;
        PrivatePropertyIndex2=StoringValues.valueToKeep6;
        MainText.text = Options[PrivatePropertyIndex1,PrivatePropertyIndex2];
    }
    public void ButtonPressed(GameObject button)
    {
        StoringValues.previousSceneIndex.Add(SceneManager.GetActiveScene().buildIndex); 
        StoringValues.previousIndex1.Add(PrivatePropertyIndex1);
        StoringValues.previousIndex2.Add(PrivatePropertyIndex2);
        //If yes is pressed at indicies 3 and 1, go to indicies 5 and 0.
        if(button.name == "YesButton" && (PrivatePropertyIndex1 == 3 && PrivatePropertyIndex2 == 1))
        {
            PrivatePropertyIndex1 = 5;
            PrivatePropertyIndex2 = 0;
            MainText.text = Options[PrivatePropertyIndex1,PrivatePropertyIndex2];
        }
        //If yes is pressed add 1 to the first index and set the second index to 0.
        else if(button.name == "YesButton")
        {
            PrivatePropertyIndex1 += 1;
            PrivatePropertyIndex2 = 0;
            MainText.text = Options[PrivatePropertyIndex1,PrivatePropertyIndex2];
        }
        //If no is pressed at indicies 3 and 1, go to indicies 5 and 1.
        if(button.name == "NoButton" && (PrivatePropertyIndex1 == 3 && PrivatePropertyIndex2 == 1))
        {
            PrivatePropertyIndex1 = 5;
            PrivatePropertyIndex2 = 1;
            MainText.text = Options[PrivatePropertyIndex1,PrivatePropertyIndex2];
        }
        //If no is pressed add 1 to the first index and set the second index to 1.
        else if(button.name == "NoButton")
        {
            PrivatePropertyIndex1 += 1;
            PrivatePropertyIndex2 = 1;
            MainText.text = Options[PrivatePropertyIndex1,PrivatePropertyIndex2];
        }
        //determines end locations, currently (1,0), (2,1)(links to passenger), (1,0)(2,1)(4,1)(4,0)(5,1)(6)
        if((PrivatePropertyIndex1 == 1 && PrivatePropertyIndex2 == 0)||(PrivatePropertyIndex1 == 2 && PrivatePropertyIndex2 == 1)||(PrivatePropertyIndex1 == 4 && PrivatePropertyIndex2 == 1)||(PrivatePropertyIndex1==4&&PrivatePropertyIndex2==0)||(PrivatePropertyIndex1==6)||(PrivatePropertyIndex1==5&&PrivatePropertyIndex2==1))
        {
            YesButton.SetActive(false);
            NoButton.SetActive(false);
        }
    }
    //resets this flowchart
    public void Restart()
    {
        SceneManager.LoadScene(3);
    }
}
