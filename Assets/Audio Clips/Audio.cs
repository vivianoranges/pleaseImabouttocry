using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    public AudioClip IntroBGM;
    public AudioClip NormalStateBGM;

    private bool inTheIntro = true;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = IntroBGM;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene" && inTheIntro)
        {
            NormalState();
        }
    }


    private void NormalState()
    {
        audioSource.clip = NormalStateBGM;
        audioSource.Play();
        inTheIntro = false;
    }
}
