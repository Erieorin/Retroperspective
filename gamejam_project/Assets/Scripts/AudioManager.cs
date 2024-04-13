using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip music;
    public AudioClip rainSFX;
    public AudioClip peopleSFX;

    private void Start()
    {
        musicSource.clip = music;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayRain()
    {
        sfxSource.clip = rainSFX;
        sfxSource.Play();
    }

    public void PlayPeople()
    {
        sfxSource.clip = peopleSFX;
        sfxSource.Play();
    }
}
