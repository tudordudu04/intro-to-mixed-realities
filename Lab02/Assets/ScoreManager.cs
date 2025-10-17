using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public float score = 0f;
    public TMPro.TextMeshProUGUI scoreText;

    private void Awake()
    {
        Instance = this;
        UpdateScore();
    }

    public void AddScore(float amount)
    {
        score += amount;
        UpdateScore();
    }

    void UpdateScore()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}