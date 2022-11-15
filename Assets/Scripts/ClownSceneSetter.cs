using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ClownSceneSetter : MonoBehaviour
{
    public GameObject ClownSc1;
    public GameObject Circus;
    private VideoPlayer videoPlayer;
    
    public CameraZoom MainCamera;
    public Camera maincamera;
    public Camera secondcamera;

    public Animator playerAnimator;
  

    public PlayerMovement scriptAtty;

    public GameObject Screamer1;
    public GameObject Screamer2;
    public GameObject Screamer3;

    public GameObject AttyFall;

    public ParticleSystem morado;
    public ParticleSystem verde;
    public ParticleSystem azul;


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
        playerAnimator = GameObject.Find("Atty").GetComponent<Animator>();
        maincamera.enabled = true;
        secondcamera.enabled = false;
        StartCoroutine(StartRoutines());
        
    }

 

    private IEnumerator StartRoutines()
    {
        yield return new WaitForSeconds(5);
        Circus.active = false;
        videoPlayer.Play();
        StartCoroutine(ActivateClown());
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
            playerAnimator.SetBool("ClownScreamer1", true);
            yield return new WaitForSeconds(1);
            playerAnimator.SetBool("ClownScreamer1", false);
            sc1 = false;
        }
       
        yield return new WaitForSeconds(10);
        if (sc2 == true)
        {
            Instantiate(Screamer2, new Vector3(20.68204f, 2.342531f, -1f), Quaternion.identity);
            playerAnimator.SetBool("ClownScreamer2", true);
            yield return new WaitForSeconds(1);
            playerAnimator.SetBool("ClownScreamer2", false);
            sc2 = false;
        }

        yield return new WaitForSeconds(10);
        if (sc3 == true)
        {
            Instantiate(Screamer3, new Vector3(19.97f, 1.02f, -1f), Quaternion.identity);
            playerAnimator.SetBool("ClownScreamer3", true);           
            sc3 = false;
            
        }
        yield return new WaitForSeconds(6);
        secondcamera.gameObject.transform.position = new Vector3(40.32f, 0.14f, 0f);
        Instantiate(AttyFall, new Vector3(40.22496f, -0.001663208f, 1f), Quaternion.identity);
        morado.Play();
        verde.Play();
        azul.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("PhobiaSelectionWireframe 1");


    }
}
