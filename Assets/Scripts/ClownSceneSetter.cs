using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ClownSceneSetter : MonoBehaviour
{
    public GameObject ClownSc1;
    public GameObject Circus;
    private VideoPlayer videoPlayer;
    
    public CameraZoom MainCamera;
    public Camera maincamera;
    public Camera secondcamera;

    void Start()
    {
        MainCamera = GameObject.Find("Main Camera").GetComponent<CameraZoom>();
        videoPlayer = GetComponent<VideoPlayer>();
        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        secondcamera = GameObject.Find("Second Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MainCamera.Zoomfinished == true)
        {
            Circus.active = false;
            videoPlayer.Play();
            StartCoroutine(ActivateClown());

        }       
        
    }

    private IEnumerator ActivateClown()
    {
        yield return new WaitForSeconds(3);
        ClownSc1.active = true;
        videoPlayer.Stop();        yield return new WaitForSeconds(3);
        maincamera.enabled = false;
        secondcamera.enabled = true;
    }
}
