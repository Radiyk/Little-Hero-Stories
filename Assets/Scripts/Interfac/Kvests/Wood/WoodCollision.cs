using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodCollision : MonoBehaviour
{
    

    public Button buttonLoot;
    private Animator anim;
	private  AudioSource MyAudioSource;

    public GameObject parent;
    public Item item;
    private float dist;
    private float minDist = 2f;

	private Transform player;


    private void Start()
	{
		anim = GetComponent<Animator>();

		MyAudioSource = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        buttonLoot.GetComponent<Button>().onClick.AddListener(delegate {CrashWood();});
	}
    

    
    public void CrashWood()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
            
        if (dist < minDist)
        {
            Inventory.instance.AddStackableItem(item);
            WoodText.wood += 1;
            anim.SetTrigger("OnCrash");
            MyAudioSource.Play();
        }
        
    }


    public void DestroyWood()
    {
        //Destroy(gameObject);
        Destroy(parent);
    }


	// private void OnDrawGizmosSelected()
	// {
	// 	Gizmos.color = Color.red;
	// 	Gizmos.DrawWireSphere(feetPos.position, checkRadius);
	// }


    
}
