using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip IntroBGM;
    public AudioClip NormalStateBGM;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayIntro();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            NormalState();
        }
    }

    private void PlayIntro()
    {
        audioSource.clip = IntroBGM;
        audioSource.Play();
    }

    private void NormalState()
    {
        audioSource.clip = NormalStateBGM;
        audioSource.Play();
    }
}
