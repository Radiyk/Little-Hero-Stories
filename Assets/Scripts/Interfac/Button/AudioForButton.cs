using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioForButton : MonoBehaviour
{
    private AudioSource MyAudioSource;
    public AudioClip[] AudioClips;
    private AudioClip loot;
    private AudioClip shop;
    private AudioClip trade;
    private AudioClip fix;

    public static int btnOptions;


    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();

        loot = MyAudioSource.clip = AudioClips[0];
        shop = MyAudioSource.clip = AudioClips[1];
        trade = MyAudioSource.clip = AudioClips[2];
        fix = MyAudioSource.clip = AudioClips[3];
    }

    public void PlayMusic()
    {
        switch (btnOptions)
{
    case 1:
        MyAudioSource.PlayOneShot(loot);
        break;
    case 2:
        MyAudioSource.PlayOneShot(shop);
        break;
    case 3:
        MyAudioSource.PlayOneShot(trade);
        break;
    case 4:
        MyAudioSource.PlayOneShot(fix);
        break;
}
    }
}
