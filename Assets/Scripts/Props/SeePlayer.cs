using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeePlayer : MonoBehaviour
{
     public GameObject bluCirkul;

	// private  AudioSource MyAudioSource;

   

     private void OnTriggerEnter2D(Collider2D Collision)
	{
		if (Collision.CompareTag("Player"))
		{
            bluCirkul.SetActive(true);
            
		}
	}


     private void OnTriggerExit2D(Collider2D Collision)
	{
		if (Collision.CompareTag("Player"))
		{
            bluCirkul.SetActive(false);
            
		}
	}
}
