using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuUIManager : MonoBehaviour
{
    public void StartGame()
    {
        FindObjectOfType<GameManager>().LoadMainGame();
    }
}
