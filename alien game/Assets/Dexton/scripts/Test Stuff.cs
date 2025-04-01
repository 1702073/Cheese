using UnityEngine;
using UnityEngine.InputSystem;

public class TestStuff : MonoBehaviour
{
    Vector2 Vector2 = new Vector2(1, 1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 = Mouse.current.position.ReadValue();
    }

    void Update()
    {
        transform.position = Vector2;
        //Mouse.current.WarpCursorPosition(Vector2.right);
    }
}
