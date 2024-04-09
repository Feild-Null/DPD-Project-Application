using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScriptDriver : MonoBehaviour
{
    public Text MainText;
    public GameObject YesButton;
    public GameObject NoButton;

    public static int DriverIndex1=StoringValues.valueToKeep;
    public static int DriverIndex2=StoringValues.valueToKeep2;
    public string[,] Options = {
    
        {//0
            "Does the suspect have a Prohibited Weapon?",
            "Does the suspect have a Prohibited Weapon?"
        },
        {//1
            "46.05 \n Felony 3",
            "Are they a Driver/Vehicle Owner?"
        },
        {//2
            "Carrying a Handgun?",
            "Passenger Chart"
        },
        {//3
            "Engaged in Criminal Activity other that M/C Traffic Offenses",
            "Engaged in Criminal Activity other that M/C Traffic Offenses"
        },
        {//4
            "46.02 (a-1)(2)(A) \n Misdemeanor A",
            "License to Carry \n AND \n Handgun is Holstered or Concealed?"
        },
        {//5
            "No Offense",
            "Documented Gang Member?"
        },
        {//6
            "46.04 (a-1) \n Misdemeanor A",
            "Handgun in Plain View?"
        },
        {//7
            "Holstered?",
            "Prior Felony Conviction?"
        },
        {//8
            "No Offense",
            "46.02 (a-1)(1) \n Misdemeanor A"
        },
        {//9
            "In Possession of a Firearm?",
            "In Possession of a Firearm?"
        },
        {//10
            "No Offense",
            "No Offense"
        },
        {//11
            "46.04 (a)(2) \n Felony 3",
            "Prior \n M/A FV Conviction?"
        },
        {//12
            "Prior M/A FV Conviction within the last five years?",
            "No Offense"
        },
        {//13
            "46.04 (b) \n Misdemeanor A",
            "Optional Alternative \n Contact the Gun Detective to file the charge in Federal Court"
        },

    };
    void Start()
    {
        MainText.text = Options[DriverIndex1,DriverIndex2];
    }
    public void ButtonPressed(GameObject button)
    {
    
        if(button.name == "YesButton" && (DriverIndex1 == 9 && DriverIndex2 == 1))
        {
            DriverIndex1 = 7;
            DriverIndex2 = 1;
            MainText.text = Options[DriverIndex1,DriverIndex2];
        }
        else if(button.name == "YesButton" && (DriverIndex1 == 7 && DriverIndex2 == 1))
        {
            DriverIndex1 = 11;
            DriverIndex2 = 0;
            MainText.text = Options[DriverIndex1,DriverIndex2];
        }
        else if(button.name == "YesButton")
        {
            DriverIndex1 += 1;
            DriverIndex2 = 0;
            MainText.text = Options[DriverIndex1,DriverIndex2];
        }
        if(button.name == "NoButton" && (DriverIndex1 == 2 && DriverIndex2 == 0))
        {
            DriverIndex1 = 9;
            DriverIndex2 = 1;
            MainText.text = Options[DriverIndex1,DriverIndex2];
        }
        else if(button.name == "NoButton" && (DriverIndex1 == 7 && DriverIndex2 == 1))
        {
            DriverIndex1 = 11;
            DriverIndex2 = 1;
            MainText.text = Options[DriverIndex1,DriverIndex2];
        }
        //Jumps to the Passenger scene at inicies 1 and 1
        else if(button.name == "NoButton" && (DriverIndex1 == 1 && DriverIndex2 == 1))
        {
            StoringValues.valueToKeep3=1;
            StoringValues.valueToKeep4=1;
            SceneManager.LoadScene(0);
            
        }
        else if(button.name == "NoButton")
        {
            DriverIndex1 += 1;
            DriverIndex2 = 1;
            MainText.text = Options[DriverIndex1,DriverIndex2];
        }
        if((DriverIndex1 == 1 && DriverIndex2 == 0)||(DriverIndex1 == 2 && DriverIndex2 == 1)||(DriverIndex1 == 4 && DriverIndex2 == 0)||(DriverIndex1==5&&DriverIndex2==0)||(DriverIndex1==6&&DriverIndex2==0)||(DriverIndex1==8&&DriverIndex2==0)||(DriverIndex1==10&&DriverIndex2==1)||(DriverIndex1==11&&DriverIndex2==0)||(DriverIndex1==12&&DriverIndex2==1)||(DriverIndex1==13)||(DriverIndex1==8))
        {
            YesButton.SetActive(false);
            NoButton.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
