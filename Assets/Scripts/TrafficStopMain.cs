using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TrafficStopMain : MonoBehaviour
{
    public void Passenger()
    {
        SceneManager.LoadScene(1);
    }
    public void Driver()
    {
        SceneManager.LoadScene(2);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
//Change