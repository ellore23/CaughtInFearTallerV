using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public MoveOnClic cameraScript;
    private float speed = 1f;
    

    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        cameraScript = FindObjectOfType<MoveOnClic>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
       if(cameraScript.trigger == true){
         rb.AddForce(transform.right * speed); 
       }
    }
}
