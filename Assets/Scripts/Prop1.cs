using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prop1 : MonoBehaviour
{
    public ActivateScene videoplayer;
    private void Start()
    {
        videoplayer = GameObject.Find("VideoPlayer").GetComponent<ActivateScene>();
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)){
            videoplayer.SetVideo(videoplayer.prop1);
           //SceneManager.LoadScene("laescenadelapelota");
        }
    }
}
