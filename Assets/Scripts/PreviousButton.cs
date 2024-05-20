using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PreviousButton : MonoBehaviour
{
    [SerializeField] GameObject YesButton;
    [SerializeField] GameObject NoButton;
    [SerializeField] GameObject NightYesButton;
    [SerializeField] GameObject NightNoButton;
    public void Previous()
    {
        YesButton.SetActive(true);
        NoButton.SetActive(true);
        NightYesButton.SetActive(true);
        NightNoButton.SetActive(true);
        //passenger
        if (StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1] == 1)
        {
            StoringValues.valueToKeep3 = StoringValues.previousIndex1[StoringValues.previousIndex1.Count-1];
            StoringValues.previousIndex1.RemoveAt(StoringValues.previousIndex1.Count-1);
            StoringValues.valueToKeep4 = StoringValues.previousIndex2[StoringValues.previousIndex2.Count-1];
            StoringValues.previousIndex2.RemoveAt(StoringValues.previousIndex2.Count-1);
        }
        //driver
        else if (StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1] == 2)
        {
            StoringValues.valueToKeep = StoringValues.previousIndex1[StoringValues.previousIndex1.Count-1];
            StoringValues.previousIndex1.RemoveAt(StoringValues.previousIndex1.Count-1);
            StoringValues.valueToKeep2 = StoringValues.previousIndex2[StoringValues.previousIndex2.Count-1];
            StoringValues.previousIndex2.RemoveAt(StoringValues.previousIndex2.Count-1);
        }
        //Private Property
        else if (StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1] == 3)
        {
            StoringValues.valueToKeep5 = StoringValues.previousIndex1[StoringValues.previousIndex1.Count-1];
            StoringValues.previousIndex1.RemoveAt(StoringValues.previousIndex1.Count-1);
            StoringValues.valueToKeep6 = StoringValues.previousIndex2[StoringValues.previousIndex2.Count-1];
            StoringValues.previousIndex2.RemoveAt(StoringValues.previousIndex2.Count-1);
        }
        //Public Places
        else if (StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1] == 4)
        {
            StoringValues.valueToKeep7 = StoringValues.previousIndex1[StoringValues.previousIndex1.Count-1];
            StoringValues.previousIndex1.RemoveAt(StoringValues.previousIndex1.Count-1);
            StoringValues.valueToKeep8 = StoringValues.previousIndex2[StoringValues.previousIndex2.Count-1];
            StoringValues.previousIndex2.RemoveAt(StoringValues.previousIndex2.Count-1);
        }
        if (StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1] != SceneManager.GetActiveScene().buildIndex)
        {
            SceneManager.LoadScene(StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1]);
        }
        StoringValues.previousSceneIndex.RemoveAt(StoringValues.previousSceneIndex.Count-1);
    }
}
