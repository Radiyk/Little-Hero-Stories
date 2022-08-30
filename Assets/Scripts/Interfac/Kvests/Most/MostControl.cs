using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostControl : MonoBehaviour

{
    
    public Button actionButton;
    public GameObject middle;
    public GameObject scoreWoodError;
    private float dist;
    private float minDist = 1.5f;
    private Transform player;

    public static bool click;

    private Animator anim;


    //private bool isClick = true;

    //private bool isCame;



    private void Start()
	{
		anim = GetComponent<Animator>();
        actionButton.GetComponent<Button>().onClick.AddListener(delegate {MostToFix();});
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
    

    
    public void MostToFix()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < minDist)
        {
            if(WoodText.woodForMost == 10)
            {
                // //WoodText.wood += 1;
                // anim.SetTrigger("ToFix");
                // isClick = false;
            }else
            {
                Debug.Log("malo");
                scoreWoodError.SetActive(true);
                Debug.Log("malo-2");
                anim.SetTrigger("isFew");
            }
            
        }
        
    }


    // public void MostPartActive()
    // {
    //     MostPart.SetActive(true);
    // }

    // private void Update()
	// {
       

	// 	if(isCame == true && click == true)
	//    {
	// 	 MostToFix();
        
	//    }

	// 	isCame = Physics2D.OverlapCircle(feetPos.position, checkRadius, Player);

	// }

	


    
}


