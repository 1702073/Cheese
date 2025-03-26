using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{

    [SerializeField] GameObject panel;

    [SerializeField] Image timeImage;

    [SerializeField] TMP_Text timeText;

    [SerializeField] float duration, currentTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panel.SetActive(false);
        currentTime = duration;
        timeText.text = currentTime.ToString();
   
    }
   IEnumerator TimeIEn()
    {
        while(currentTime>=0)
        {
            timeImage.fillAmount = Mathf.InverseLerp(0,duration, currentTime);
            timeText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
      
      
    }


   
}
