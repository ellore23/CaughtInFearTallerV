using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ActivateScene : MonoBehaviour
{
    public GameObject fondo;
    private VideoPlayer videoPlayer;
    public VideoClip prop1;
    public VideoClip prop2;
    public VideoClip prop3;
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(videoPlayer.isPlaying == false){ 
         fondo.SetActive(true);
            Debug.Log("activau");
        }
        else
        {
            fondo.SetActive(false);
            Debug.Log("desactivau");
        }
    }

    public void SetVideo(VideoClip prop) {

        videoPlayer.clip = prop;
        videoPlayer.Play();
    }
}
