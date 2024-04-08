using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PublicPlaceScript : MonoBehaviour
{
    public TMP_Text MainText;
    public GameObject YesButton;
    public GameObject NoButton;

    [SerializeField] int index1 = 0;
    [SerializeField] int index2 = 0;
    // list of possible outputs
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
    void Start()
    {
        MainText.text = Options[index1,index2];
    }
    public void ButtonPressed(GameObject button)
    {
    
        if(button.name == "YesButton" && (index1 == 3 && index2 == 1))
        {
            index1 = 12;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "YesButton" && (index1 == 5 && index2 == 0))
        {
            index1 = 16;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "YesButton" && (index1 == 2 && index2 == 1))
        {
            index1 = 2;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "YesButton" && (index1 == 11 && index2 == 0))
        {
            index1 = 17;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "YesButton")
        {
            index1 += 1;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        if(button.name == "NoButton" && (index1 == 2 && index2 == 1))
        {
            index1 = 11;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "NoButton" && (index1 == 5 && index2 == 1))
        {
            index1 = 16;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "NoButton")
        {
            index1 += 1;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        //The places where the path ends
        if((index1 == 1 && index2 == 0)|| (index1 == 4 && index2 == 0)||(index1 == 6 && index2 == 0)
        ||(index1 == 7 && index2 == 0)||(index1 == 8 && index2 == 0)||(index1 == 9 && index2 == 0)
        ||(index1 == 10 && index2 == 0)||(index1 == 10 && index2 == 1)||(index1 == 13 && index2 == 0)
        ||(index1 == 14 && index2 == 1)||(index1 == 15 && index2 == 0)||(index1 == 15 && index2 == 1)
        ||(index1 == 16 && index2 == 0)||(index1 == 16 && index2 == 1)||(index1 == 17 && index2 == 0))
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
//Change