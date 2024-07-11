using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject levelComplete;
    public GameObject TapToStart;
    public GameObject scoreText;

    public void Start()
    {
        gameOverPanel.SetActive(false);
        TapToStart.SetActive(true);
        scoreText.SetActive(false);
        levelComplete.SetActive(false);
        PauseGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    public void GameOver()
    {
        scoreText.SetActive(false);
        gameOverPanel.SetActive(true);
    }
    public void LevelComplete()
    {
        scoreText.SetActive(false);
        levelComplete.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        levelComplete.SetActive(false);
        TapToStart.SetActive(false);
        scoreText.SetActive(true);
        Time.timeScale = 1f;
    }
}