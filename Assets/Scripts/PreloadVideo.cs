using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PreloadVideo : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    void Awake()
    {
        videoPlayer.Prepare();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
