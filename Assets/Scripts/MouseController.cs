using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public Texture2D mainCursor;
    public Texture2D clickCursor;



    void Awake()
    {
        //ChangeCursor(mainCursor);
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
    
    void ChangeCursor(Texture2D cursorType)
    {
        //Cursor.SetCursor(cursorType,Vector2.zero, CursorMode.Auto);
    }
    
}
