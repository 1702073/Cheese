using UnityEngine;
using UnityEngine.UI;

public class ClockTimer : MonoBehaviour
{
    public Text timer;
    float currentvalue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentvalue = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        currentvalue-= 1 * Time.deltaTime;
        timer.text = currentvalue.ToString("0");
        if (currentvalue <= 0)
        {
            timer.text = "End";
        }
    }
}
