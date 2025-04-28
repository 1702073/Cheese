using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class Draggable : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;

     void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }
    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseDrag()
    {
        dragging = false;
    }

   
}
