using UnityEngine;

public class NPCController : MonoBehaviour
{
    public enum NPState { Idle, PickedUp, Dropped }

    public NPState currentState = NPState.Idle;
    

    void Start()
    {
        currentState = NPState.Idle;
    }

    void Update()
    {
        switch (currentState)
        {
            case NPState.Idle:
                // Idle behavior
                break;
            case NPState.PickedUp:
                // Held behavior (e.g., move with Player)
                break;
            case NPState.Dropped:
                // Dropped behavior (e.g., resume AI)
                break;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && currentState == NPState.Idle && Input.GetButtonDown("PickUp"))
        {
            currentState = NPState.PickedUp;
            // Additional logic: Set NPC as child of player, update position, etc.
        }
    }
 
}


