using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequiredComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.loop = true
        _audioSource.spatialBlend = 0;
    }

    public void playMusic(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }
}
