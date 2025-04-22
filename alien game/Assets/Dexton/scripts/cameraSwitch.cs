using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class cameraSwitch : MonoBehaviour
{
    public GameObject cam1, cam2, cam3, cam4, flicker;
    void Update()
    {
        if (Input.GetKeyDown("1"))
            CameraOne();

        if (Input.GetKeyDown("2"))
            CameraTwo();

        if (Input.GetKeyDown("3"))
            CameraThree();

        if (Input.GetKeyDown("4"))
            CameraFour();
    }
    public void CameraFlicker()
    {
        flicker.SetActive(true);
    }
        
    void CameraOne()
    {
        CameraFlicker();
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }
    void CameraTwo()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }
    void CameraThree()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
        cam4.SetActive(false);
    }
    public void CameraFour()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(true);
    }


}