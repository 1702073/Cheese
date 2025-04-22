using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    
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

    private bool dialogueActivated;
    private int step;

    // Update is called once per frame
    void Update()
    {



        if (Input.GetButtonDown("Interact") && dialogueActivated == true)
        {
            if (step >= speaker.Length)
            {
                dialogueCanvas.SetActive(false);
                step = 0;
            }
            else
            {
                dialogueCanvas.SetActive(true);
                SpeakerText.text = speaker[step];
                dialogueText.text = dialogueWords[step];
                PortraitImage.sprite = portrait[step];
                step += 1;
            }
            

        }
    }




}