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
    public void Previous()
    {
        YesButton.SetActive(true);
        NoButton.SetActive(true);
        //passenger
        if (StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1] == 0)
        {
            StoringValues.valueToKeep3 = StoringValues.previousIndex1[StoringValues.previousIndex1.Count-1];
            StoringValues.previousIndex1.RemoveAt(StoringValues.previousIndex1.Count-1);
            StoringValues.valueToKeep4 = StoringValues.previousIndex2[StoringValues.previousIndex2.Count-1];
            StoringValues.previousIndex2.RemoveAt(StoringValues.previousIndex2.Count-1);
        }
        //driver
        else if (StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1] == 1)
        {
            StoringValues.valueToKeep = StoringValues.previousIndex1[StoringValues.previousIndex1.Count-1];
            StoringValues.previousIndex1.RemoveAt(StoringValues.previousIndex1.Count-1);
            StoringValues.valueToKeep2 = StoringValues.previousIndex2[StoringValues.previousIndex2.Count-1];
            StoringValues.previousIndex2.RemoveAt(StoringValues.previousIndex2.Count-1);
        }
        if (StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1] != SceneManager.GetActiveScene().buildIndex)
        {
            SceneManager.LoadScene(StoringValues.previousSceneIndex[StoringValues.previousSceneIndex.Count-1]);
            StoringValues.previousSceneIndex.RemoveAt(StoringValues.previousSceneIndex.Count-1);
        }
        
    }
}
