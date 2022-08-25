using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTake : MonoBehaviour
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
            anim.SetTrigger("MoneyTake");
            MyAudioSource.Play();
			ManeyText.maney += 1;
			PlayerPrefs.SetInt("Maney", ManeyText.maney);
		}
	}

    public void DestroyMoney()
    {
        Destroy(gameObject);
    }
}
