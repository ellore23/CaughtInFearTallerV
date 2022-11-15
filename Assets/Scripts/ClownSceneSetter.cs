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

    public GameObject ottyui;
    public GameObject prefabtext;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    public GameObject text9;
    public GameObject text10;
    public GameObject text11;
    public GameObject text12;


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
       
        videoPlayer.Stop();        
        yield return new WaitForSeconds(3);
        maincamera.enabled = false;
        secondcamera.enabled = true;

        //primer parte
        Instantiate(ottyui, new Vector3(21.04f, -0.83f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(2);
        var prefab=Instantiate(prefabtext, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(14);
        Destroy(prefab);
        yield return new WaitForSeconds(5);

        var t1 = Instantiate(text1, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t1);
        var t2 = Instantiate(text2, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t2);
        var t3 = Instantiate(text3, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t3);

        yield return new WaitForSeconds(6);      
        Instantiate(Screamer1, new Vector3(17.38977f, 2.284655f, -1f), Quaternion.identity);
        playerAnimator.SetBool("ClownScreamer1", true);
        yield return new WaitForSeconds(1);
        playerAnimator.SetBool("ClownScreamer1", false);
        var t4 = Instantiate(text4, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t4);
        var t5 = Instantiate(text5, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t5);




        //segunda parte
        yield return new WaitForSeconds(10);
        Instantiate(Screamer2, new Vector3(20.68204f, 2.342531f, -1f), Quaternion.identity);
        playerAnimator.SetBool("ClownScreamer2", true);
        yield return new WaitForSeconds(1);
        playerAnimator.SetBool("ClownScreamer2", false);
        var t6 = Instantiate(text6, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t6);
        yield return new WaitForSeconds(4);
        var t7 = Instantiate(text7, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(3);
        Destroy(t7);
        var t8 = Instantiate(text8, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(3);
        Destroy(t8);

        yield return new WaitForSeconds(8);
        var t9 = Instantiate(text9, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t9);
        var t10= Instantiate(text10, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t10);
        yield return new WaitForSeconds(10);




        yield return new WaitForSeconds(10);
        Instantiate(Screamer3, new Vector3(19.97f, 1.02f, -1f), Quaternion.identity);
        playerAnimator.SetBool("ClownScreamer3", true);
        var t12 = Instantiate(text12, new Vector3(20.75f, -3.69f, -11.5f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t12);
              
   
        yield return new WaitForSeconds(3);
        secondcamera.gameObject.transform.position = new Vector3(40.32f, 0.14f, 0f);
        Instantiate(AttyFall, new Vector3(40.22496f, -0.001663208f, 1f), Quaternion.identity);
        morado.Play();
        verde.Play();
        azul.Play();
        PhobiaSelectionObjDetector.propCount++;
        PhobiaSelectionObjDetector.Clicprop1 = true;
        yield return new WaitForSeconds(1);
        if (PhobiaSelectionObjDetector.propCount >2)
        {
            SceneManager.LoadScene("Ending");
        }
        else
        {
            SceneManager.LoadScene("PhobiaSelectionNoVideo");
        }
        


    }
}
