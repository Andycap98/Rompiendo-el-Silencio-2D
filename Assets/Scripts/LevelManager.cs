using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [Header("Configuración del Nivel")]
    public float timeRemaining = 30f;
    public int targetScore = 10;

    [Header("UI Textos")]
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;

    [Header("Paneles de Estado")]
    public GameObject winPanel;
    public GameObject losePanel;

    private int currentScore = 0;
    private bool isGameActive = true;

    void Start()
    {
        UpdateScoreUI();
        UpdateTimerUI();

        if (winPanel != null) winPanel.SetActive(false);
        if (losePanel != null) losePanel.SetActive(false);
    }

    void Update()
    {
        if (!isGameActive) return;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerUI();
        }
        else
        {
            timeRemaining = 0;
            UpdateTimerUI();
            CheckGameOver();
        }
    }

    public void AddPoint()
    {
        if (!isGameActive) return;

        currentScore++;
        UpdateScoreUI();

        if (currentScore >= targetScore)
        {
            WinGame();
        }
    }

    void CheckGameOver()
    {
        if (currentScore < targetScore)
        {
            LoseGame();
        }
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            int seconds = Mathf.CeilToInt(timeRemaining);
            timerText.text = $"Tiempo: {seconds}s";
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Insultos: {currentScore} / {targetScore}";
        }
    }

    void WinGame()
    {
        isGameActive = false;
        if (winPanel != null) winPanel.SetActive(true);
        Time.timeScale = 0f; // Detiene el juego
    }

    void LoseGame()
    {
        isGameActive = false;
        if (losePanel != null) losePanel.SetActive(true);
        Time.timeScale = 0f;
    }
}