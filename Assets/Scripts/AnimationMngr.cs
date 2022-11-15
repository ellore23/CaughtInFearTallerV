using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class AnimationMngr : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public VideoClip clip1;
    public VideoClip clip2;
    public GameObject atty;
    private bool Anim1Ended = false;

    public Camera maincamera;
    public Camera secondcamera;

    public GameObject leftWall;
    public GameObject rightWall;
    public GameObject taburete;
    public GameObject AttyFall;

    public ParticleSystem morado;
    public ParticleSystem verde;
    public ParticleSystem azul;

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

    public GameObject ottyui;
    public GameObject attyAnimMngr;
    

    void Start()
    {
        maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        secondcamera = GameObject.Find("Second camera").GetComponent<Camera>();
        

        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {         
        if (videoPlayer.isPlaying == false)
        {
            videoPlayer.clip = clip1;
            videoPlayer.Play();

            if(videoPlayer.clip == clip1 && Anim1Ended == false)
            {
                StartCoroutine(PlayThirdClipOnLoop());
            }
        }
    }

    public IEnumerator PlayThirdClipOnLoop()
    {
        yield return new WaitForSeconds(7);
        Anim1Ended = true;
        
        Instantiate(atty, new Vector3(21.095705f, -1.21168661f, -0.412089586f), Quaternion.identity);
        var firstIntantiatedAtty = Instantiate(atty, new Vector3(0.924000025f, -1.45f, -0.412089586f), Quaternion.identity);

        videoPlayer.clip = clip2;
        videoPlayer.Play();
        videoPlayer.isLooping = true;
        yield return new WaitForSeconds(12);
        Destroy(firstIntantiatedAtty);        
        videoPlayer.Stop();
        maincamera.enabled = false;
        secondcamera.enabled = true;
        Instantiate(ottyui, new Vector3(22.63f, -0.67f, -2f), Quaternion.identity);
        Instantiate(attyAnimMngr);

        yield return new WaitForSeconds(2);
        var t1 = Instantiate(text1, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t1);
        var t2 = Instantiate(text2, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t2);
        var t3 = Instantiate(text3, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t3);
        var t4 = Instantiate(text4, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t4);

        //primera parte

        yield return new WaitForSeconds(5);
        leftWall.transform.Translate(0.5f, 0f, 0f);
        taburete.transform.Translate(0.5f, 0f, 0f);
        rightWall.transform.Translate(-0.5f, 0f, 0f);
        var t5 = Instantiate(text5, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t5);
        var t6 = Instantiate(text6, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t6);
        var t7 = Instantiate(text7, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t7);

        //segunda parte

        yield return new WaitForSeconds(5);
        leftWall.transform.Translate(0.5f, 0f, 0f);
        taburete.transform.Translate(0.5f, 0f, 0f);
        rightWall.transform.Translate(-0.5f, 0f, 0f);
        var t8 = Instantiate(text8, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t8);
        var t9 = Instantiate(text9, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t9);
        var t10 = Instantiate(text10, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t10);


        yield return new WaitForSeconds(5);
        leftWall.transform.Translate(0.5f, 0f, 0f);
        taburete.transform.Translate(0.5f, 0f, 0f);
        rightWall.transform.Translate(-0.5f, 0f, 0f);
        var t11 = Instantiate(text11, new Vector3(22.5200005f, -3.79999995f, -2f), Quaternion.identity);
        yield return new WaitForSeconds(4);
        Destroy(t11);
        yield return new WaitForSeconds(3);

        secondcamera.gameObject.transform.position = new Vector3(40f, -0.03f, 0f);
        Instantiate(AttyFall, new Vector3(40f, -0.03f, 1f), Quaternion.identity);
        morado.Play();
        verde.Play();
        azul.Play();
        PhobiaSelectionObjDetector.propCount++;
        PhobiaSelectionObjDetector.Clicprop2 = true;
        yield return new WaitForSeconds(1.5f);
        if (PhobiaSelectionObjDetector.propCount > 2)
        {
            SceneManager.LoadScene("Ending");
        }
        else
        {
            SceneManager.LoadScene("PhobiaSelectionNoVideo");
        }


    }

    



}
