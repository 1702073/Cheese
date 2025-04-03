using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor.Tilemaps;
using UnityEngine;

public class NPC_Wander : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private float leftParolx, rightParolx;

    [SerializeField] private float minPauseTime, maxPauseTime;
    [SerializeField] private float minWalkTime, maxWalkTime;

    [SerializeField] private int facingDirection = -1;

    private float randomTime, timer;
    private bool isWalking = true;

    private void Start()
    {
        randomTime = Random.Range(minWalkTime, maxWalkTime);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= randomTime)
            StateChange();

        if (transform.position.x > rightParolx || transform.position.x < leftParolx)
            Flip();

        if(isWalking)
            rb.linearVelocity = Vector2.right * facingDirection * speed;
    }


    void Flip()
    {
        transform.Rotate(0, 180, 0);
        facingDirection *= -1;
    }

    void StateChange()
    {
        isWalking = !isWalking;
        randomTime = isWalking ? Random.Range(minWalkTime, maxWalkTime) : Random.Range(minPauseTime, maxPauseTime);
        timer = 0;
    }
}
