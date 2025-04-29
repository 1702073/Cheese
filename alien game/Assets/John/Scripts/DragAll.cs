using System.Xml;
using UnityEngine;

public class DragAll : MonoBehaviour
{
    private Transform dragging = null;
    private Vector3 offset;
    [SerializeField] private LayerMask movableLayers;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        { 
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero,
                float.PositiveInfinity, movableLayers);

            if (hit)
            {
                dragging = hit.transform;
                offset = dragging.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            }
            else if(Input.GetMouseButton(1))
            {
                dragging = null;
            }
            if(dragging != null)
            {
                dragging.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            }
        }
    }
}
