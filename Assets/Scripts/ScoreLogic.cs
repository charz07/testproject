using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreLogic : MonoBehaviour
{
    public long playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool over = false;
    [ContextMenu("Increase Score")]
    public void addScore ()
    {
        if(over==false) 
        {
            playerScore = playerScore + 3;
        }
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        over = true;
    }
}
