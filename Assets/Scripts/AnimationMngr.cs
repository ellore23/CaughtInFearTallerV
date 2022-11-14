using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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


    }
}
