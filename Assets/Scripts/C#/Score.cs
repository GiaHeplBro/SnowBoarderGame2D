using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;

    private int score = 0;
    private int highscore = 0;

    void Start()
    {
        // Lấy highscore từ PlayerPrefs nếu có
        highscore = PlayerPrefs.GetInt("Highscore", 0);

        // Hiển thị điểm số ban đầu
        UpdateUI();
    }

    // Hàm để tăng điểm
    public void AddScore(int amount)
    {
        score += amount;

        // Kiểm tra nếu score mới cao hơn highscore thì cập nhật
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
            PlayerPrefs.Save();
        }

        UpdateUI();
    }

    // Cập nhật UI
    private void UpdateUI()
    {
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }
}
