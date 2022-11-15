using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Prop3 : MonoBehaviour
{
    public ActivateScene videoplayer;
    private VideoPlayer Video;

    public float delay = 10f;
    
    private void Start()
    {
        videoplayer = GameObject.Find("VideoPlayer").GetComponent<ActivateScene>();
        Video = GameObject.Find("VideoPlayer").GetComponent<VideoPlayer>();
    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && PhobiaSelectionObjDetector.Clicprop3 == false)
        {
            videoplayer.SetVideo(videoplayer.prop3);            
            Invoke(nameof(LoadNextScene), delay);        
        }
    }

    void LoadNextScene() {
        SceneManager.LoadScene("Nictophobia 1");
    
    }
}

