using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScriptDriver : MonoBehaviour
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
            "46.02 (a-1)(1) \n Misdemeanor A",
            "No Offense"
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
        MainText.text = Options[index1,index2];
    }
    public void ButtonPressed(GameObject button)
    {
    
        if(button.name == "YesButton" && (index1 == 9 && index2 == 1))
        {
            index1 = 7;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "YesButton" && (index1 == 7 && index2 == 1))
        {
            index1 = 11;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "YesButton")
        {
            index1 += 1;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        if(button.name == "NoButton" && (index1 == 2 && index2 == 0))
        {
            index1 = 9;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "NoButton" && (index1 == 7 && index2 == 1))
        {
            index1 = 11;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "NoButton")
        {
            index1 += 1;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        if((index1 == 1 && index2 == 0)||(index1 == 2 && index2 == 1)||(index1 == 4 && index2 == 0)||(index1==5&&index2==0)||(index1==6&&index2==0)||(index1==8&&index2==0)||(index1==10&&index2==1)||(index1==11&&index2==0)||(index1==12&&index2==1)||(index1==13))
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
