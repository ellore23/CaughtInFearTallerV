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
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (videoPlayer.isPlaying == false)
        {
            videoPlayer.clip = clip1;
            videoPlayer.Play();

            if(videoPlayer.clip == clip1)
            {
                StartCoroutine(PlayThirdClipOnLoop());
            }
        }
    }

    public IEnumerator PlayThirdClipOnLoop()
    {
        yield return new WaitForSeconds(7);
        Instantiate(atty, new Vector3(1.2f, -2.05f, -0.4f), Quaternion.identity);
        videoPlayer.clip = clip2;
        videoPlayer.Play();
        videoPlayer.isLooping = true;
    }
}
