using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{
    public Texture2D mainCursor;
    public Texture2D clickCursor;

    public Button start;
    public float Title;
    public float alphaLevel = 1f;

    void Awake()
    {
        //ChangeCursor(mainCursor);
        start = GameObject.Find("StartButton").GetComponent<Button>();
        Title = GameObject.Find("Titulo").GetComponent<SpriteRenderer>().color.a;
        Cursor.SetCursor(mainCursor, Vector2.zero, CursorMode.ForceSoftware);
        Cursor.lockState = CursorLockMode.Confined;

        
    }

    void FixedUpdate(){

        if(Input.GetMouseButton(0)){
            Cursor.SetCursor(clickCursor, Vector2.zero, CursorMode.ForceSoftware);
        }
        else{
            Cursor.SetCursor(mainCursor, Vector2.zero, CursorMode.ForceSoftware);
        }
       
    }

    void ButtonClicked()
    {
       
    }


 
    
}
