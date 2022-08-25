using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechNPC : MonoBehaviour
{
    public Button buttonSpeech;
    public GameObject speechObject;
    public GameObject interfaceObject;

    private float dist;
    private float minDist = 2f;

	private Transform player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        buttonSpeech.GetComponent<Button>().onClick.AddListener(delegate {SpeechActive();});
    }

    public void SpeechActive()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
            
        if (dist < minDist)
        {
            speechObject.SetActive(true);
            interfaceObject.SetActive(false);
        }
        
    }
}
