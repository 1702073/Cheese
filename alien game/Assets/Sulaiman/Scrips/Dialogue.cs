using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public System.Random randomTime = new();

    //UI References
    [SerializeField]
    private GameObject dialogueCanvas;


    [SerializeField]
    private TMP_Text SpeakerText;

    [SerializeField]
    private TMP_Text dialogueText;

    [SerializeField]
    private Image PortraitImage;


    //Dialogue Content
    [SerializeField]
    private string[] speaker;

    [SerializeField]
    [TextArea]
    private string[] dialogueWords;

   
    [SerializeField]
    private Sprite[] portrait;

    private int step;

    // Update is called once per frame
    public void Start()
    {
        dialogueCanvas.SetActive(false);
        int time = randomTime.Next(1, 60);
        Invoke("showDialogue", time);
    }

    void Update()
    {
        
    }

    private void showDialogue()
    {
        dialogueCanvas.SetActive(true);
        int index = randomTime.Next(0, speaker.Length);
        SpeakerText.SetText(speaker[index]);
        dialogueText.SetText(dialogueWords[index]);
        PortraitImage.sprite = portrait[index];


    }
    public void HideDialogue()
    {
        dialogueCanvas.SetActive(false);
        int time = randomTime.Next(1, 6);
        Invoke("showDialogue", time);
    }
}