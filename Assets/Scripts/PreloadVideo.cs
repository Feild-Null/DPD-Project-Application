using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PreloadVideo : MonoBehaviour
{
    [SerializeField] VideoPlayer lightVideoPlayer;
    [SerializeField] VideoPlayer darkVideoPlayer;


    void Awake()
    {
        lightVideoPlayer.Prepare();
        darkVideoPlayer.Prepare();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
