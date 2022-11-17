using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Prop1 : MonoBehaviour
{
    public ActivateScene videoplayer;
    private VideoPlayer Video;
    float delay = 10f;
    private void Start()
    {
        videoplayer = GameObject.Find("VideoPlayer").GetComponent<ActivateScene>();
        Video = GameObject.Find("VideoPlayer").GetComponent<VideoPlayer>();
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            videoplayer.SetVideo(videoplayer.prop1);
            Invoke(nameof(LoadNextScene), delay);
            

        }
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene("Clownphobia");

    }
}
