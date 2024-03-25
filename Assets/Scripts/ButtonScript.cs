using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public TMP_Text MainText;
    public GameObject YesButton;
    public GameObject NoButton;

    [SerializeField] int index1 = 0;
    [SerializeField] int index2 = 0;
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
            "Prior M/A Family Violence Conviction?"
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
            "Prior M/A Family Violence Conviction?"
        },
        {
            "46.02 (a-7)(e)(2) Felony 3",
            "Prior Conviction for:\n Assault, Deadly Conduct,\n Terroristic Threat,\n Disorderly Conduct\n(Display/Discharge)?"
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
//Hello Peoples