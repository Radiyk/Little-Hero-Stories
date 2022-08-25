using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenBonfire : MonoBehaviour
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
          
            anim.SetTrigger("PlayerTach");
            MyAudioSource.Play();
		}
	}

    public void OpenBonfireScene()
    {
        SceneManager.LoadScene(1);
    }
}
