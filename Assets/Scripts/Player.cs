using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float jumpForce = 5f;

    Rigidbody2D myRigidbody;
    Animator myAnimator;
    AudioManager myAudioManager;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myAudioManager = FindObjectOfType<AudioManager>();
    }

    private void Start()
    {
        myAnimator.SetBool("isFlapping", true);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && myAnimator.GetBool("isFlapping"))
        {
            myRigidbody.velocity = new Vector3(0, jumpForce, 0);
            myAudioManager.PlaySwooshSFX();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            myAnimator.SetBool("isFlapping", false);
            transform.Rotate(new Vector3(0, 0, 180));
        }
    }

}
