using UnityEngine;

public class InputManager : MonoBehaviour
{
   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)|| Input.GetKeyDown(KeyCode.E))
        {
            AudioManager.Instance.Play(AudioManager.SoundType.CameraSwitch);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            AudioManager.Instance.Play(AudioManager.SoundType.AlienPickup);
        }
      
    }
}
