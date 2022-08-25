using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTake : MonoBehaviour
{
    private Animator anim;

	private  AudioSource MyAudioSource;

    private void Start()
	{
		anim = GetComponent<Animator>();

		MyAudioSource = GetComponent<AudioSource>();

	}

    private void OnTriggerEnter2D(Collider2D Collision)
	{
		if (Collision.CompareTag("Player"))
		{
            anim.SetTrigger("AppleTake");
            MyAudioSource.Play();
			AppleText.apple += 1;
			PlayerPrefs.SetInt("Apple", AppleText.apple);
		}
	}

    public void DestroyApple()
    {
        Destroy(gameObject);
    }
}
