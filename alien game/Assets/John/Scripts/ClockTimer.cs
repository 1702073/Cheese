using UnityEngine;
using UnityEngine.UI;

public class ClockTimer : MonoBehaviour
{
   [SerializeField]
    public float totalTime = 10f; // Total countdown time in seconds
    public Text countdownText; // UI Text element to display the timer

    private float currentTime;
    private bool countdownStarted = false;

    void Start()
    {
        currentTime = totalTime;
   
    }

    void Update()
    {
        if (countdownStarted)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = Mathf.Ceil(currentTime).ToString(); // Display as a whole number

            if (currentTime <= 0)
            {
                // Countdown finished, do something here
                Debug.Log("Countdown finished!");
                // You can add code here to start the game, etc.
                countdownStarted = false; // Stop the countdown
            }
        }
      
    }

    // Called when the player enters the trigger collider
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the colliding object is the player
        {
            countdownStarted = true;
        }
    }
    
    

   
}
