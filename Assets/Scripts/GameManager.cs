using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject menuUI, loseUI;
    public PipeSpawner pipeSpawner;
    public CoinSpawner coinSpawner;
    public PlayerController playerController;
    public int points = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    [SerializeField] private AudioSource coinSound;
    [SerializeField] private AudioSource deathSound;

    public void StartGame()
    {
        menuUI.SetActive(false);
        pipeSpawner.enabled = true;
        coinSpawner.enabled = true;
        playerController.enabled = true;
        playerController.rb.simulated = true;
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void OnGameOver()
    {
        deathSound.PlayDelayed(0.25f);
        ShowHighscore();
        ShowLoseUI();
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        points++;
        coinSound.Play();
        scoreText.text = points.ToString();
    }

    public void ShowHighscore() {
        DataManager.Instance.HighScore();
        highScoreText.text = "Your best score is: " + DataManager.Instance.LoadScore();
    }
}
