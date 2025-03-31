using UnityEngine;

public class InputManager : MonoBehaviour
{
   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)|| Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.Instance.Play(AudioManager.SoundType.Jump);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            AudioManager.Instance.Play(AudioManager.SoundType.Shoot);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            AudioManager.Instance.Play(AudioManager.SoundType.Powerup);
        }
    }
}
