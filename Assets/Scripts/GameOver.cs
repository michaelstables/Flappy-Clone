using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    AudioManager myAudioManager;
    GameManager gameManager;

    private void Awake()
    {
        myAudioManager = FindObjectOfType<AudioManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(DeathSequence());
        }

    }

    IEnumerator DeathSequence()
    {
        FindObjectOfType<AudioManager>().PlayDieSFX();
        yield return new WaitForSecondsRealtime(1);
        FindObjectOfType<GameManager>().LoadGameOver();
        StopCoroutine(DeathSequence());
    }
}
