using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOutput : MonoBehaviour
{
    public AudioSource beating;

    void Start()
    {
        beating = GetComponent<AudioSource>();
        InvokeRepeating("PlayAudio", 5.0f, 1.5f);
    }

    void PlayAudio()
    {
        beating.Play();
    }
}
