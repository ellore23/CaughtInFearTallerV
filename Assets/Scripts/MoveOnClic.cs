using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClic : MonoBehaviour
{
    //Variable

    public bool trigger;

    void Start()
    {
           trigger = false;
    }

    void FixedUpdate(){
        OnMouseOver();
    }

    void OnMouseOver(){
    if(Input.GetMouseButton(0)){
       
       trigger = true;
    }
    else{
        trigger = false;
        
    }
 }
}
