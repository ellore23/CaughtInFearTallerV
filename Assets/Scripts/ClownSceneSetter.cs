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
    public Camera thirdcamera;

    public PlayerMovement scriptAtty;

    public GameObject Screamer1;
    public GameObject Screamer2;
    public GameObject Screamer3;

    public GameObject AttyFall;

    bool sc1 = true;
    bool sc2 = true;
    bool sc3 = true;

    void Start()
    {
        scriptAtty = GameObject.Find("Atty").GetComponent<PlayerMovement>();
        MainCamera = GameObject.Find("Main Camera").GetComponent<CameraZoom>();
        videoPlayer = GetComponent<VideoPlayer>();
        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        secondcamera = GameObject.Find("Second Camera").GetComponent<Camera>();
        thirdcamera = GameObject.Find("Third Camera").GetComponent<Camera>();
        maincamera.enabled = true;
        secondcamera.enabled = false;
        thirdcamera.enabled = false;
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
        

        yield return new WaitForSeconds(10);
        if(sc1 == true)
        {
            Instantiate(Screamer1, new Vector3(17.38977f, 2.284655f, -1f), Quaternion.identity);
            sc1 = false;
        }
       
        yield return new WaitForSeconds(10);
        if (sc2 == true)
        {
            Instantiate(Screamer2, new Vector3(20.68204f, 2.342531f, -1f), Quaternion.identity);
            sc2 = false;
        }

        yield return new WaitForSeconds(10);
        if (sc3 == true)
        {
            Instantiate(Screamer3, new Vector3(19.97f, 1.02f, -1f), Quaternion.identity);
            sc3 = false;
        }
        yield return new WaitForSeconds(5);
        secondcamera.enabled = false;
        thirdcamera.enabled = true;
        Instantiate(AttyFall, new Vector3(4.155933f, -0.7988773f, 1f), Quaternion.identity);


    }
}
