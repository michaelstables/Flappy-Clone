using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    int playerScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    Player player;
    Animator playerAnimator;
    AudioManager myAudioManager;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "MainGame")
        {
            player = FindObjectOfType<Player>();
            playerAnimator = player.GetComponent<Animator>();

            myAudioManager = FindObjectOfType<AudioManager>();
        }
      
        int numberOfGameManagers = FindObjectsOfType<GameManager>().Length;
        if (numberOfGameManagers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "MainGame")
        {
            scoreText.text = playerScore.ToString();
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainGame")
        {
            scoreText.text = playerScore.ToString();
        }
    }

    public int GetScore()
    {
        return playerScore;
    }

    public void UpdateScore()
    {
        if (playerAnimator.GetBool("isFlapping") == true)
        {
            myAudioManager.PlayPointSFX();
            playerScore++;
        }
 
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Destroy(gameObject);
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene("MainGame");
        Destroy(gameObject);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
