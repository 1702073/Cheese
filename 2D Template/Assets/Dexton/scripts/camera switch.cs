using UnityEngine;

public class cameraSwitch : MonoBehaviour
{
    GameObject cam1, cam2, cam3;
    /*KeyCode switchLeft = KeyCode.LeftArrow, switchRight = KeyCode.RightArrow; // Key to switch to the first camera
    //public CamUsing camUsing; // Enum to determine which camera is currently in use

    public enum CamUsing
    {
        Cam1 = 0,
        Cam2 = 1,
        Cam3 = 2
    }*/
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne();
        }

        if (Input.GetKeyDown("2"))
        {
            CameraTwo();
        }

        if (Input.GetKeyDown("3"))
        {
            CameraThree();
        }
    }

    void CameraOne()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
    }
    void CameraTwo()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
    }
    void CameraThree()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
    }
    /*void ManagerCamera()
    {
        {
          
            if (camUsing == CamUsing.Cam1)
            {
                cam1();
            }
            else if (Input.GetKeyDown(switchLeft) && camUsing == CamUsing.Cam2)
            {
                cam1.SetActive(false); // Deactivate the first camera
                cam2.SetActive(true); // Activate the second camera
                cam3.SetActive(false); // Deactivate the third camera
            }
            else if (Input.GetKeyDown(switchLeft) && camUsing == CamUsing.Cam3)
            {
                cam1.SetActive(false); // Deactivate the first camera
                cam2.SetActive(false); // Deactivate the second camera
                cam3.SetActive(true); // Activate the third camera
            }

            if (Input.GetKeyDown(switchRight) && camUsing == CamUsing.Cam1)
            {
                cam1.SetActive(false); // Activate the first camera
                cam2.SetActive(false); // Deactivate the second camera
                cam3.SetActive( true); // Deactivate the third camera
            }
            else if (Input.GetKeyDown(switchRight) && camUsing == CamUsing.Cam2)
            {
                cam1.SetActive(true); // Deactivate the first camera
                cam2.SetActive(false); // Activate the second camera
                cam3.SetActive(false); // Deactivate the third camera
            }
            else if (Input.GetKeyDown(switchRight) && camUsing == CamUsing.Cam3)
            {
                cam1.SetActive(false); // Deactivate the first camera
                cam2.SetActive(true); // Deactivate the second camera
                cam3.SetActive(false); // Activate the third camera
            }
        }// Update the camUsing enum based on which camera is active        
    }*/

}