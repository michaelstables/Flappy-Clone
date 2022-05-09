using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip dieSFX;
    [SerializeField] AudioClip pointSFX;
    [SerializeField] AudioClip swooshSFX;
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayDieSFX()
    {
        audioSource.PlayOneShot(dieSFX);
    }

    public void PlayPointSFX()
    {
        audioSource.PlayOneShot(pointSFX);
    }

    public void PlaySwooshSFX()
    {
        audioSource.PlayOneShot(swooshSFX);
    }
}
