using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public MoveOnClic cameraScript;
    private float speed = 0.4f;

    [SerializeField]
    Animator animatorCont;
    

    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        animatorCont = GetComponent<Animator>();
        cameraScript = FindObjectOfType<MoveOnClic>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
       if(cameraScript.trigger == true){
         rb.AddForce(transform.right * speed);
            animatorCont.SetBool("walkingAnimator", true);
       }
        else
        {
            rb.velocity = Vector3.zero;
            animatorCont.SetBool("walkingAnimator", false);

        }
    }
}
