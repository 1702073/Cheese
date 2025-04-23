using UnityEngine;
using UnityEngine.UI;


public class StayAtSpot : MonoBehaviour
{
    private bool countdownStarted = false;
    public float stayDuration = 15f; // Time to stay at the current position
    public float movementSpeed = 2f; // Speed of movement to the spot
    private bool staying = false;
    private Vector2 targetPosition;

    void Start()
    {
       
        targetPosition = transform.position; // Initial position
        staying = false; // Start by moving to the initial positions
    }

    void Update()
    {
        if (staying) return; // If already staying, don't move
       // Move to the target position
        Vector2 currentPosition = transform.position;
        if (Vector2.Distance(currentPosition, targetPosition) > Mathf.Epsilon)
        {
            transform.position = Vector2.MoveTowards(currentPosition, targetPosition, movementSpeed * Time.deltaTime);
        }
        else
        {
            StartCoroutine(StayAtSpotRoutine()); // Start the delay when the object reaches the spot
        }
       
    }
 
    System.Collections.IEnumerator StayAtSpotRoutine()
    {
        staying = true; // Set staying to true
        yield return new WaitForSeconds(stayDuration); // Wait for the specified duration
        staying = false; // Reset staying after the delay
        // Optionally, you can add code here to move the object to a new position after the delay
        // For example:  MoveToNewPosition();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) // Check if the colliding object is the player
        {
            countdownStarted = true;
        }
    }
}
