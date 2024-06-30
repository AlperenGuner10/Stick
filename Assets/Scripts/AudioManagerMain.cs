using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerMain : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;

    public AudioClip Music;

    public void Start()
    {
        AudioSource.clip = Music;
        AudioSource.Play();
    }
}
