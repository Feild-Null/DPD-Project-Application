using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScriptPassenger : MonoBehaviour
{
    public Text MainText;
    public Text NightText;
    public GameObject YesButton;
    public GameObject NoButton;
    public GameObject NightYesButton;
    public GameObject NightNoButton;

    public static int PassengerIndex1=StoringValues.valueToKeep3;
    public static int PassengerIndex2=StoringValues.valueToKeep4;
    public string[,] Options = {
    
        {
            "Does the suspect have a Prohibited Weapon?",
            "Does the suspect have a Prohibited Weapon?"
        },
        {
            "46.05 Felony 3",
            "Are they a passenger?"
        },
        {
            "Carrying a Handgun?",
            "Driver Chart"
        },
        {
            "Documented Gang Member?",
            "In Possession of a Firearm?"
        },
        {
            "Prior Felony Conviction?",
            "No Offense"
        },
        {
            "46.04 (A)(1) Felony 3",
            "Prior M/A Family Violence Conviction within 5 years?"
        },
        {
            "46.04 (b) Misdemeanor A",
            "No Offense"
        },
        {
            "46.04 (a-1) Misdemeanor A",
            "Prior Felony Conviction?"
        },
        {
            "46.02 (a-7)(e)(1) Felony 2, Five Year Mandatory Minimum Sentence",
            "Prior M/A Family Violence Conviction within 5 years?"
        },
        {
            "46.02 (a-7)(e)(2) Felony 3",
            "Prior Conviction for: Assault, Deadly Conduct, Terroristic Threat, Disorderly Conduct (Display/Discharge)?"
        },
        {
            "46.02 (a)(2)(B) Misdemeanor A",
            "17 or older?"
        },
        {
            "No Offense",
            "46.02 (a)(2)(A) Misdemeanor A"
        },

    };
    public void Awake()
    {
        PassengerIndex1=StoringValues.valueToKeep3;
        PassengerIndex2=StoringValues.valueToKeep4;
        MainText.text = Options[PassengerIndex1,PassengerIndex2];
        NightText.text = Options[PassengerIndex1,PassengerIndex2];
    }
    public void ButtonPressed(GameObject button)
    {
        StoringValues.previousSceneIndex.Add(SceneManager.GetActiveScene().buildIndex); 
        StoringValues.previousIndex1.Add(PassengerIndex1);
        StoringValues.previousIndex2.Add(PassengerIndex2);
        if(button.name == "YesButton" && (PassengerIndex1 == 3 && PassengerIndex2 == 0))
        {
            PassengerIndex1 = 7;
            PassengerIndex2 = 0;
            MainText.text = Options[PassengerIndex1,PassengerIndex2];
            NightText.text = Options[PassengerIndex1,PassengerIndex2];
        }
        else if(button.name == "YesButton")
        {
            PassengerIndex1 += 1;
            PassengerIndex2 = 0;
            MainText.text = Options[PassengerIndex1,PassengerIndex2];
            NightText.text = Options[PassengerIndex1,PassengerIndex2];
        }
        if(button.name == "NoButton" && (PassengerIndex1 == 3 && PassengerIndex2 == 0))
        {
            PassengerIndex1 = 7;
            PassengerIndex2 = 1;
            MainText.text = Options[PassengerIndex1,PassengerIndex2];
            NightText.text = Options[PassengerIndex1,PassengerIndex2];
        }
        //Jumps to the Driver scene at inicies 1 and 1
        else if(button.name == "NoButton" && (PassengerIndex1 == 1 && PassengerIndex2 == 1))
        {
            StoringValues.valueToKeep=1;
            StoringValues.valueToKeep2=1;
            SceneManager.LoadScene(2);
            
        }
        else if(button.name == "NoButton")
        {
            PassengerIndex1 += 1;
            PassengerIndex2 = 1;
            MainText.text = Options[PassengerIndex1,PassengerIndex2];
            NightText.text = Options[PassengerIndex1,PassengerIndex2];
        }
        if((PassengerIndex1 == 1 && PassengerIndex2 == 0)||(PassengerIndex1 == 2 && PassengerIndex2 == 1)||(PassengerIndex1 == 4 && PassengerIndex2 == 1)||(PassengerIndex1==5&&PassengerIndex2==0)||(PassengerIndex1==6)||(PassengerIndex1==7&&PassengerIndex2==0)||(PassengerIndex1==8&&PassengerIndex2==0)||(PassengerIndex1==9&&PassengerIndex2==0)||(PassengerIndex1==10&&PassengerIndex2==0)||(PassengerIndex1==11))
        {
            YesButton.SetActive(false);
            NoButton.SetActive(false);
            NightYesButton.SetActive(false);
            NightNoButton.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
//test