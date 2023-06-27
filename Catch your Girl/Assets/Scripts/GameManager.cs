using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    bool gameOver = false;

    public int score = 0;
    public TextMeshProUGUI scoreText;

    public GameObject gameOverPanel;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        CheckHighScore();
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    void CheckHighScore()
    {
        if (score > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }
    }

    public void GameOver()
    {
        gameOver = true;

        GameObject.Find("ObjectSpawner").GetComponent<ObjectSpawner>().StopSpawningObstacles();

        gameOverPanel.SetActive(true);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1.0f;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }
}
