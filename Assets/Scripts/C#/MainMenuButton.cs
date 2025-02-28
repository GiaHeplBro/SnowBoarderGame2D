using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Import để thay đổi UI

public class MainMenuButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Exit()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }    

}
