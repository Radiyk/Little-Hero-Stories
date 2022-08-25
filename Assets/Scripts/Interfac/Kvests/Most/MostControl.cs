using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostControl : MonoBehaviour

{
    

    public static bool click;

    private Animator anim;

	private  AudioSource MyAudioSource;

    private bool isClick = true;

    private bool isCame;
    public GameObject MostPart;

    public Transform feetPos;
    public float checkRadius;
	public LayerMask Player;


    private void Start()
	{
		anim = GetComponent<Animator>();

		MyAudioSource = GetComponent<AudioSource>();

        
	}
    

    
    public void MostToFix()
    {
        if(isClick)
        {
            //WoodText.wood += 1;
            anim.SetTrigger("ToFix");
            MyAudioSource.Play();
            // Debug.Log(click);
            isClick = false;
        }
        
    }


    public void MostPartActive()
    {
        MostPart.SetActive(true);
    }

    private void Update()
	{
       

		if(isCame == true && click == true)
	   {
		 MostToFix();
        
	   }

		isCame = Physics2D.OverlapCircle(feetPos.position, checkRadius, Player);

	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(feetPos.position, checkRadius);
	}


    
}


