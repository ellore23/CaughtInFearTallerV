using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    Camera maincamera;
    public Transform target;
    float maxZoom = 0.3f;    
    float timer = 0f;
    float time = 10000f;
    public bool Zoomfinished = false;

    private void Start()
    {
       maincamera = GetComponent<Camera>();
       target = GameObject.Find("Target").GetComponent<Transform>();
    }
    private void Update()
    {
        StartCoroutine(ZoomCamera());
        if(Zoomfinished == true)
        {
            maincamera.orthographicSize = 5f;
            maincamera.transform.position = new Vector3(0f, 0.14f, -10f);
        }
    }

    public IEnumerator ZoomCamera()
    {
        yield return new WaitForSeconds(3);
        while (timer < time)
        {
            timer += Time.deltaTime;
            maincamera.orthographicSize = maincamera.orthographicSize = Mathf.Lerp(maincamera.orthographicSize, maxZoom, timer / time);
            maincamera.transform.position = maincamera.transform.position = Vector3.Lerp(maincamera.transform.position,target.position, timer / time);
            yield return null;
        }
        maincamera.orthographicSize = maxZoom;
        
        Zoomfinished = true;
}
}
