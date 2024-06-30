using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip Sensation;
    public void Start()
    {
        musicSource.clip = Sensation;
        musicSource.Play();
    }
}
