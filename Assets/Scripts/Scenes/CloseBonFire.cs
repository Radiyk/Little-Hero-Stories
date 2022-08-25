using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseBonFire : MonoBehaviour
{
    private Animator anim;

	private  AudioSource MyAudioSource;

    private void Start()
	{
		anim = GetComponent<Animator>();

		MyAudioSource = GetComponent<AudioSource>();

	}
        
    

     public void Play()
	{
		 
            anim.SetTrigger("PlayerGoo");
            MyAudioSource.Play();
		
	}

    public void OpenWorld()
    {
        SceneManager.LoadScene(2);
    }
}
