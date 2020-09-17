using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class cursorBehaviour : MonoBehaviour {

    // Reference to the three cursor images
    public Texture2D curPoint;
    public Texture2D curHover;
    public Texture2D curClick;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Cursor.SetCursor(curClick, Vector2.zero, CursorMode.Auto);
        }
        else if (EventSystem.current.IsPointerOverGameObject())
        {
            Cursor.SetCursor(curHover, Vector2.zero, CursorMode.Auto);
        }
        else
        {
           Cursor.SetCursor(curPoint, Vector2.zero, CursorMode.Auto);
        }
    }
}
