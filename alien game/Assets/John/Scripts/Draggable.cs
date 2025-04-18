using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class Draggable : MonoBehaviour
{
    Vector3 mousePositionOffset;

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
       mousePositionOffset=gameObject.transform.position-GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
       transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }
   
}
