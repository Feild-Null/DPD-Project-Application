using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScriptPublicPlaces : MonoBehaviour
{
    public Text MainText;
    public Text NightText;
    public GameObject YesButton;
    public GameObject NoButton;
    public GameObject NightYesButton;
    public GameObject NightNoButton;

    public static int PublicPlaceIndex1=StoringValues.valueToKeep7;
    public static int PublicPlaceIndex2=StoringValues.valueToKeep8;
    public string[,] Options = {
    
        {
            //0-0
            "Does the suspect have a Prohibited Weapon?",
            "Does the suspect have a Prohibited Weapon?"
        },
        {
            //1-1; 1-2
            "46.05 Felony 3",
            "Was the entire encounter in a public place?"
        },
        {
            //2-1; 2-2
            "Carrying a handgun?",
            "Did the suspects actions bing them into a public place?"
        },
        {
            //3-1; 3-2
            "Prior Felony Conviction?",
            "Carrying long gun or firearm?"
            //3-2 leads to 12-1
        },
        {
            //4-1; 4-2
            "46.02 (a-7)(e)(1) Felony 2; Five year mandatory minimum",
            "M/A Family violence conviction?"
        },
        {
            //5-1; 5-2
            "Conviction in the last five years?",
            "Prior conviction for; deadly conduct, terroristic threat, or disorderly conduct?"
            //Leads to 16-1; 16-2
        },
        {
            //6-1; 6-2
            "46.02 (a)(2)(B) Misdemeanor A",
            "Are they intoxicated?"
        },
        {
            //7-1; 7-2
            "46.02 (a)(2)(A)",
            "16 or younger?"
        },
        {
            //8-1; 8-2
            "46.02 (a)(2)(A) Misdemeanor A",
            "Is the fiream fully concealed?"
        },
        {
            //9-1; 9-2
            "No offense",
            "Holstered"
        },
        {
            //10-1; 10-2
            "No offense",
            "46.02 (a-5) Misdemeanor A"
        },
        {
            //11-1; 11-2
            "Officer's actions led suspect to public place?",
            "Officer's actions led suspect to public place?"
        },
        {
            //12-1; 12-2
            "Prior felony conviction?",
            "Prior felony conviction?"
        },
        {
            //13-1; 13-2
            "46.04 (a)(1) Felony 3",
            "Prior M/A family violence conviction?"
        },
        {
            //14-1; 14-2
            "Convicion in the last five years?",
            "No offense"
        },
        {
            //15-1; 15-2
            "46.04 (2)(b)",
            "Optional alternaive: Contact the gun detective to file the charge in federal court"
        },
        {
            //16-1; 16-2
            "46.02 (a-7)(e)(2) felony 3",
            "Optional alternaive: Contact the gun detective to file the charge in federal court"
        },
        {
            //17-1; 17-2
            "Link to Private scene",
            "Link to Private scene"
        },

    };
    public void Awake()
    {
        PublicPlaceIndex1=StoringValues.valueToKeep7;
        PublicPlaceIndex2=StoringValues.valueToKeep8;
        MainText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
        NightText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
    }
    public void ButtonPressed(GameObject button)
    {
        StoringValues.previousSceneIndex.Add(SceneManager.GetActiveScene().buildIndex); 
        StoringValues.previousIndex1.Add(PublicPlaceIndex1);
        StoringValues.previousIndex2.Add(PublicPlaceIndex2);
        if(button.name == "YesButton" && (PublicPlaceIndex1 == 3 && PublicPlaceIndex2 == 1))
        {
            PublicPlaceIndex1 = 12;
            PublicPlaceIndex2 = 0;
            MainText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
            NightText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
        }
        else if(button.name == "YesButton" && (PublicPlaceIndex1 == 5 && PublicPlaceIndex2 == 0))
        {
            PublicPlaceIndex1 = 16;
            PublicPlaceIndex2 = 0;
            MainText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
            NightText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
        }
        else if(button.name == "YesButton" && (PublicPlaceIndex1 == 2 && PublicPlaceIndex2 == 1))
        {
            PublicPlaceIndex1 = 2;
            PublicPlaceIndex2 = 0;
            MainText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
            NightText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
        }
        else if(button.name == "YesButton" && (PublicPlaceIndex1 == 11 && PublicPlaceIndex2 == 0))
        {
            PublicPlaceIndex1 = 17;
            PublicPlaceIndex2 = 0;
            MainText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
            NightText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
        }
        else if(button.name == "YesButton")
        {
            PublicPlaceIndex1 += 1;
            PublicPlaceIndex2 = 0;
            MainText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
            NightText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
        }
        if(button.name == "NoButton" && (PublicPlaceIndex1 == 2 && PublicPlaceIndex2 == 1))
        {
            PublicPlaceIndex1 = 11;
            PublicPlaceIndex2 = 0;
            MainText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
            NightText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
        }
        else if(button.name == "NoButton" && (PublicPlaceIndex1 == 5 && PublicPlaceIndex2 == 1))
        {
            PublicPlaceIndex1 = 16;
            PublicPlaceIndex2 = 1;
            MainText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
            NightText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
        }
        else if(button.name == "NoButton")
        {
            PublicPlaceIndex1 += 1;
            PublicPlaceIndex2 = 1;
            MainText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
            NightText.text = Options[PublicPlaceIndex1,PublicPlaceIndex2];
        }
        //The places where the path ends
        if((PublicPlaceIndex1 == 1 && PublicPlaceIndex2 == 0)|| (PublicPlaceIndex1 == 4 && PublicPlaceIndex2 == 0)||(PublicPlaceIndex1 == 6 && PublicPlaceIndex2 == 0)
        ||(PublicPlaceIndex1 == 7 && PublicPlaceIndex2 == 0)||(PublicPlaceIndex1 == 8 && PublicPlaceIndex2 == 0)||(PublicPlaceIndex1 == 9 && PublicPlaceIndex2 == 0)
        ||(PublicPlaceIndex1 == 10 && PublicPlaceIndex2 == 0)||(PublicPlaceIndex1 == 10 && PublicPlaceIndex2 == 1)||(PublicPlaceIndex1 == 13 && PublicPlaceIndex2 == 0)
        ||(PublicPlaceIndex1 == 14 && PublicPlaceIndex2 == 1)||(PublicPlaceIndex1 == 15 && PublicPlaceIndex2 == 0)||(PublicPlaceIndex1 == 15 && PublicPlaceIndex2 == 1)
        ||(PublicPlaceIndex1 == 16 && PublicPlaceIndex2 == 0)||(PublicPlaceIndex1 == 16 && PublicPlaceIndex2 == 1)||(PublicPlaceIndex1 == 17 && PublicPlaceIndex2 == 0))
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
//Change