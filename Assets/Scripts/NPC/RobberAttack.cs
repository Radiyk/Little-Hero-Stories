using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobberAttack : MonoBehaviour
{
    //private GameObject player;

    private AudioSource MyAudioSource;

    private AgentMeshPatrol agent;

    public AudioClip[] AudioClips;
    private AudioClip grabyoj;
    private AudioClip smehRobber;

    bool isRobbery = false;

    void Start()
    {
        // player = GameObject.FindGameObjectWithTag("Player");
        // player.GetComponent<PlayerTopDownControl>();

        MyAudioSource = GetComponent<AudioSource>();
        agent = GetComponent<AgentMeshPatrol>();

        grabyoj = MyAudioSource.clip = AudioClips[0];
        smehRobber = MyAudioSource.clip = AudioClips[1];
    }

    private void OnTriggerEnter2D(Collider2D Collision)
	{
		if (Collision.CompareTag("Player"))
		{
            if (isRobbery == false)
            {
                isRobbery = true;
                // anim.SetTrigger("MoneyTake");
                MyAudioSource.PlayOneShot(grabyoj);
                ManeyText.maney = 0;
                PlayerPrefs.SetInt("Maney", ManeyText.maney);
                agent.distanceAttack = 0;
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerTopDownControl>().ShowMoney();
            }
		}
	}

     private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (isRobbery == true)
            {
                
                    MyAudioSource.PlayOneShot(smehRobber);
                
               

            }
        

        }
    }

    
}
