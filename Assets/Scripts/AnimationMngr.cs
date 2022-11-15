using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        yield return new WaitForSeconds(10);
        leftWall.transform.Translate(0.5f, 0f, 0f);
        taburete.transform.Translate(0.5f, 0f, 0f);
        rightWall.transform.Translate(-0.5f, 0f, 0f);
        yield return new WaitForSeconds(3);
        leftWall.transform.Translate(0.5f, 0f, 0f);
        taburete.transform.Translate(0.5f, 0f, 0f);
        rightWall.transform.Translate(-0.5f, 0f, 0f);
        yield return new WaitForSeconds(3);
        leftWall.transform.Translate(0.5f, 0f, 0f);
        taburete.transform.Translate(0.5f, 0f, 0f);
        rightWall.transform.Translate(-0.5f, 0f, 0f);
        yield return new WaitForSeconds(6);

        secondcamera.gameObject.transform.position = new Vector3(40f, -0.03f, 0f);
        Instantiate(AttyFall, new Vector3(40f, -0.03f, 1f), Quaternion.identity);
        morado.Play();
        verde.Play();
        azul.Play();

        Debug.Log("sex");
    }

    



}
