using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpWood : MonoBehaviour
{
    public Item item;
    public Button actionButton;
    public GameObject parent;
    private float dist;
    private float minDist = 1.5f;
    private Transform player;

    private Animator animation;
	private AudioSource MyAudioSource;

    void Start()
    {
        actionButton.GetComponent<Button>().onClick.AddListener(delegate {TakeLoot();});
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animation = GetComponent<Animator>();

		MyAudioSource = GetComponent<AudioSource>();
    }
    


    public void TakeLoot()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < minDist)
        {
            Inventory.instance.AddStackableItem(item);
            DestroyObj();
        }
    }

    public void DestroyObj()
    {
        WoodText.woodForMost += 1;
        animation.SetTrigger("OnCrash");
        MyAudioSource.Play();
    }
    
    
    public void DestroyWood()
    {
        Destroy(parent);
    }
}
