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
    public AudioClip calmSFX;
    public AudioClip tensionSFX;
    public AudioClip melanhSFX;

    private void Start()
    {
        musicSource.clip = music;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayRain()
    {
        sfxSource.clip = rainSFX;
        sfxSource.loop = true;
        sfxSource.Play();
    }

    public void PlayPeople()
    {
        sfxSource.clip = peopleSFX;
        sfxSource.Play();
    }

    public void PlayCalm()
    {
        sfxSource.clip = calmSFX;
        sfxSource.loop = true;
        sfxSource.Play();
    }

    public void PlayTension()
    {
        sfxSource.clip = tensionSFX;
        sfxSource.loop = true;
        sfxSource.Play();
    }

    public void PlayMel()
    {
        sfxSource.clip = melanhSFX;
        sfxSource.loop = true;
        sfxSource.Play();
    }
}
