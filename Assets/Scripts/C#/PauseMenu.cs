using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    private bool isPaused = false; // Biến kiểm tra trạng thái Pause

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Nhấn ESC để bật/tắt Pause
        {
            if (isPaused)
                Continue();
            else
                Pause();
        }
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }
}
