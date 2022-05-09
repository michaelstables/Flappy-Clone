using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullPipe : MonoBehaviour
{
    [SerializeField] float moveSpeed = -1f;
    Vector3 moveDirection = new Vector3();

    GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Start()
    {
        moveDirection = new Vector3(moveSpeed, 0, 0);
    }

    void Update()
    {
        transform.Translate(moveDirection * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.UpdateScore();
        }
    }
}
