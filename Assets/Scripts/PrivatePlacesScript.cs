using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PrivatePlaceScript : MonoBehaviour
{
    public TMP_Text MainText;
    public GameObject YesButton;
    public GameObject NoButton;

    [SerializeField] int index1 = 0;
    [SerializeField] int index2 = 0;
    // list of possible outputs
    public string[,] Options = {
    
        {
            "Does the suspect have a Prohibited Weapon?",
            "Does the suspect have a Prohibited Weapon?"
        },
        {
            "46.05 Felony 3",
            "Was the entire encounter in a public place?"
        },
        {
            "Prior Felony Conviction?",
            "Carrying long gun or firearm?"
        },
        {
            "46.02 (a-7)(e)(1) Felony 2; Five year mandatory minimum",
            "M/A Family violence conviction?"
        },
        {
            "Conviction in the last five years?",
            "Prior conviction for; deadly conduct, terroristic threat, or disorderly conduct?"
        },
        {
            "46.02 (a)(2)(B) Misdemeanor A",
            "Are they intoxicated?"
        },
        {
            "46.02 (a)(2)(A)",
            "16 or younger?"
        },
        {
            "46.02 (a)(2)(A) Misdemeanor A",
            "Is the fiream fully concealed?"
        },
        {
            "No offense",
            "Holstered"
        },
        {
            "No offense",
            "46.02 (a-5) Misdemeanor A"
        },
        {
            "Officer's actions led suspect to public place?",
            "Officer's actions led suspect to public place?"
        },
        {
            "Prior felony conviction?",
            "Prior felony conviction?"
        },
        {
            "46.04 (a)(1) Felony 3",
            "Prior M/A family violence conviction?"
        },
        {
            "Convicion in the last five years?",
            "No offense"
        },
        {
            "46.04 (2)(b)",
            "Optional alternaive: Contact the gun detective to file the charge in federal court"
        },
        {
            "46.02 (a-7)(e)(2) felony 3",
            "Optional alternaive: Contact the gun detective to file the charge in federal court"
        },

    };
    void Start()
    {
        MainText.text = Options[index1,index2];
    }
    public void ButtonPressed(GameObject button)
    {
    
        if(button.name == "YesButton" && (index1 == 3 && index2 == 0))
        {
            index1 = 7;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "YesButton")
        {
            index1 += 1;
            index2 = 0;
            MainText.text = Options[index1,index2];
        }
        if(button.name == "NoButton" && (index1 == 3 && index2 == 0))
        {
            index1 = 7;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        else if(button.name == "NoButton")
        {
            index1 += 1;
            index2 = 1;
            MainText.text = Options[index1,index2];
        }
        if((index1 == 1 && index2 == 0)||(index1 == 2 && index2 == 1)||(index1 == 4 && index2 == 1)||(index1==5&&index2==0)||(index1==6)||(index1==7&&index2==0)||(index1==8&&index2==0)||(index1==9&&index2==0)||(index1==10&&index2==0)||(index1==11))
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
