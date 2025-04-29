using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;
public class Draggable : MonoBehaviour
{
    [SerializeField]
    public string Newtag = "Morbs";
    private bool dragging = false;
    private Vector3 offset;

    private void Start()
    {
        gameObject.tag = "Morbs";
    }
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject != null)
        {
            gameObject.tag = "Morbs ";
            Debug.Log($"Tag changed for {collision.gameObject.name} to Morbs");
        }
       
    }
}
