using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScriptPassenger : MonoBehaviour
{
    public TMP_Text MainText;
    public GameObject YesButton;
    public GameObject NoButton;

    [SerializeField] int index1 = 0;
    [SerializeField] int index2 = 0;
    //all the possible text scenarios. sections labeled by index, and referenced by [index1, index2]
    public string[,] Options = {
    
        {//0
            "Does the suspect have a Prohibited Weapon?",
            "Does the suspect have a Prohibited Weapon?"
        },
        {//1
            "46.05 Felony 3",
            "Are they a passenger?"
        },
        {//2
            "Carrying a Handgun?",
            "Driver Chart"
        },
        {//3
            "Documented Gang Member?",
            "In Possession of a Firearm?"
        },
        {//4
            "Prior Felony Conviction?",
            "No Offense"
        },
        {//5
            "46.04 (A)(1) Felony 3",
            "Prior M/A Family Violence Conviction?"
        },
        {//6
            "46.04 (b) Misdemeanor A",
            "No Offense"
        },
        {//7
            "46.04 (a-1) Misdemeanor A",
            "Prior Felony Conviction?"
        },
        {//8
            "46.02 (a-7)(e)(1) Felony 2, Five Year Mandatory Minimum Sentence",
            "Prior M/A Family Violence Conviction?"
        },
        {//9
            "46.02 (a-7)(e)(2) Felony 3",
            "Prior Conviction for:\n Assault, Deadly Conduct,\n Terroristic Threat,\n Disorderly Conduct\n(Display/Discharge)?"
        },
        {//10
            "46.02 (a)(2)(B) Misdemeanor A",
            "17 or older?"
        },
        {//11
            "No Offense",
            "46.02 (a)(2)(A) Misdemeanor A"
        },

    };


    //sets up the text
    void Start()
    {
        MainText.text = Options[index1,index2];
    }
    public void ButtonPressed(GameObject button)
    {
        //If yes is pressed at indicies 3 and 0, go to indicies 7 and 0.
        if(button.name == "YesButton" && (index1 == 3 && index2 == 0))
        {
            index1 = 7;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        //If yes is pressed add 1 to the first index and set the second index to 0.
        else if(button.name == "YesButton")
        {
            index1 += 1;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        //If yes is pressed at indicies 3 and 0, go to indicies 7 and 1.
        if(button.name == "NoButton" && (index1 == 3 && index2 == 0))
        {
            index1 = 7;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        //If no is pressed add 1 to the first index and set the second index to 1.
        else if(button.name == "NoButton")
        {
            index1 += 1;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        //determines end locations, currently (1,0), (2,1)(links to driver), (4,1), (5,0), (6,0), (6,1), (7,0), (8,0), (9,0), (10,0), (11,0), (11, 1)
        if((index1 == 1 && index2 == 0)||(index1 == 4 && index2 == 1)||(index1==5&&index2==0)||(index1==6)||(index1==7&&index2==0)||(index1==8&&index2==0)||(index1==9&&index2==0)||(index1==10&&index2==0)||(index1==11))
        {
            YesButton.SetActive(false);
            NoButton.SetActive(false);
        }
        //links the flowchart endpoint (2,1) to the passenger chart
        else if((index1 == 2 && index2 == 1))
        {
            SceneManager.LoadScene(1);
        }
    }


    //resets this flowchart
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
