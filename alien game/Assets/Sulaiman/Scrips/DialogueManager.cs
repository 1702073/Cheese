using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel; // Assign the Panel in the inspector
    public Text dialogueText; // Assign the Text element in the inspector
    public List<string> dialogueMessages; // A list of dialogue messages
    public float displayDuration = 3f; // How long the dialogue is displayed

    private bool isDialogueActive = false;

    // Function to start the dialogue
    public void StartDialogue()
    {
        if (isDialogueActive) return; // Prevent multiple dialogues from overlapping
        isDialogueActive = true;

        // Get a random dialogue message
        int randomIndex = Random.Range(0, dialogueMessages.Count);
        string randomMessage = dialogueMessages[randomIndex];

        // Display the dialogue message
        dialogueText.text = randomMessage;
        dialoguePanel.SetActive(true);

        // Call function to hide dialogue after displayDuration
        StartCoroutine(HideDialogue());
    }

    // Coroutine to hide the dialogue after a set time
    private System.Collections.IEnumerator HideDialogue()
    {
        yield return new WaitForSeconds(displayDuration);
        dialoguePanel.SetActive(false);
        isDialogueActive = false;
    }
}