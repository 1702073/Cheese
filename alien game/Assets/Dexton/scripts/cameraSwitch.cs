using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class cameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    public GameObject cam8;

    public GameObject flicker;
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

        if (Input.GetKeyDown("5"))
            CameraFive();

        if (Input.GetKeyDown("6"))
            CameraSix();

        if (Input.GetKeyDown("7"))
            CameraSeven();

        if (Input.GetKeyDown("8"))
            CameraEight();
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
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(false);
        cam8.SetActive(false);

    }
    void CameraTwo()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(false);
        cam8.SetActive(false);
    }
    void CameraThree()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(false);

        cam8.SetActive(false);
    }
    public void CameraFour()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(true);
        cam5.SetActive(false);
        cam6.SetActive(false);

        cam7.SetActive(false);


        cam8.SetActive(false);
    }

    public void CameraFive()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(true);
        cam6.SetActive(false);

        cam7.SetActive(false);

        cam8.SetActive(false);

    }

    public void CameraSix()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(true);
        cam7.SetActive(false);
        cam8.SetActive(false);
    }

    public void CameraSeven()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(true);
        cam8.SetActive(false);
    }
    public void CameraEight()
    {
        CameraFlicker();
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(false);
        cam8.SetActive(true);
    }
}