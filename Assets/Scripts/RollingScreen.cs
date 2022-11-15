using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingScreen : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    bool finished = false;
   

    void Start()
    {
        offset = transform.position - player.transform.position;
        StartCoroutine(WaitingforAnim());
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(finished == true)
        {
            transform.position = player.transform.position + offset;
        }
       
        
    }

    public IEnumerator WaitingforAnim()
    {
        yield return new WaitForSeconds(2);
        finished = true;
        yield return null; 
    }
}
