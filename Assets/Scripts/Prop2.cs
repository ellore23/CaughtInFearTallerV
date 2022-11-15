using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Prop2 : MonoBehaviour
{
    public ActivateScene videoplayer;
    private VideoPlayer Video;

    private void Start()
    {
        videoplayer = GameObject.Find("VideoPlayer").GetComponent<ActivateScene>();
        Video = GameObject.Find("VideoPlayer").GetComponent<VideoPlayer>();
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            videoplayer.SetVideo(videoplayer.prop2);
            if (Video.isPlaying == false)
            {
                SceneManager.LoadScene("Claustrophobia");
            }
        }
    }
}

