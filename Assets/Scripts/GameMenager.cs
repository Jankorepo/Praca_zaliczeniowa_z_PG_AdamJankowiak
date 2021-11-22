using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameStartCanvas;
    public GameObject gameRestartButtonCanvas;
    public GameObject gameWonCanvas;
    void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        gameRestartButtonCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void GameStart()
    {
        gameStartCanvas.SetActive(true);
        gameRestartButtonCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void GameWon()
    {
        gameWonCanvas.SetActive(true);
        gameRestartButtonCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
