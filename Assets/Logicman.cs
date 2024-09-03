using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logicman : MonoBehaviour
{
    public GameObject GameOverScreen;
    public GameObject WinScreen;
    public int playerScore;
    public Text scoreText;
    public bool playerAlive;
    public GameObject Player;
    public GameObject platform;
    public GameObject platspawner;
    public GameObject yellowspawner;
    public int ScoreToWin;
    private void Start()
    {
        playerAlive = true;
        platform.SetActive(true);
        platspawner.SetActive(true);
        yellowspawner.SetActive(true);
    }
    private void Update()
    {
        HaveWeWonYet();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }    
    public void winGame()
    {
        WinScreen.SetActive(true);
    }
    public void HaveWeWonYet()
    {
        if (playerScore == ScoreToWin)
        {
            winGame();
            playerAlive = false;
            platform.SetActive(false);
            platspawner.SetActive(false);
            yellowspawner.SetActive(false);
            Player.SetActive(false);
        }
    }

}
