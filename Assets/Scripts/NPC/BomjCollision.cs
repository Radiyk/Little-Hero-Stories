using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomjCollision : MonoBehaviour
{
    private AudioSource MyAudioSource;
    private DropLoot dropLoot;
    public AudioClip[] AudioClips;
    private AudioClip bomj_plach;
    private AudioClip bomj_spech;
    private AudioClip bomj_sps;
    private float speed;
    private Patrol speedPatrol;

    
    private bool secretSpeech = false;

    public GameObject attention;
    public GameObject menu_NPC;


    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
        dropLoot = GetComponent<DropLoot>();
        speedPatrol = GetComponent<Patrol>();

        bomj_plach = MyAudioSource.clip = AudioClips[0];
        bomj_spech = MyAudioSource.clip = AudioClips[1];
        bomj_sps = MyAudioSource.clip = AudioClips[2];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (secretSpeech ==false)
            {
                speedPatrol.normalSpeed =  0;
                menu_NPC.SetActive(true);
                MyAudioSource.PlayOneShot(bomj_plach);

            }

        }
    }

    


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            menu_NPC.SetActive(false);
            speedPatrol.normalSpeed =2;

            if (MenuNPC.present == true || MenuNPC.danat == true)
            {
                MyAudioSource.PlayOneShot(bomj_sps);
            }

            if (MenuNPC.present == true && MenuNPC.danat == true)
            {
                speedPatrol.normalSpeed =0;
                attention.SetActive(true);
                secretSpeech = true;
                MyAudioSource.PlayOneShot(bomj_spech);
                MenuNPC.present = false;
                MenuNPC.danat = false;
                StartCoroutine(ThrowLoot());
            }
        

        }
    }

    
     IEnumerator ThrowLoot()
    {
       
        yield return new WaitForSeconds(11);

        dropLoot.ShotLoot();
       
    }
}
