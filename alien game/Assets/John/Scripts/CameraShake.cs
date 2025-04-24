using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float shakeAmount = 0.02f;
    private Vector2 initialPos;

    private void Awake()
    {
        initialPos = transform.position;
    }

    private void Update()
    {
        transform.position = initialPos + Random.insideUnitCircle * shakeAmount;
    }
}
