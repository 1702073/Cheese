using UnityEngine;
using UnityEngine.InputSystem;

public class TestStuff : MonoBehaviour
{
    Vector2 Vector2 = new Vector2(1, 1);
    void Start()
    {
        Vector2 =  Mouse.current.position.ReadValue();
    }

    void Update()
    {
        Mouse.current.WarpCursorPosition(Vector2.right);
        Vector2 = transform.position;
    }
}
