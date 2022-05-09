using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverUIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    private void Update()
    {
        DisplayFinalScore();
    }

    void DisplayFinalScore()
    {
        scoreText.text = "Your Score: " + FindObjectOfType<GameManager>().GetScore().ToString();
    }

    public void MainMenu()
    {
        FindObjectOfType<GameManager>().LoadStartMenu();
    }

    public void Replay()
    {
        FindObjectOfType<GameManager>().LoadMainGame();
    }
}
