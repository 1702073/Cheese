using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private int sceneToLoad;
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("Button Clicked");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
