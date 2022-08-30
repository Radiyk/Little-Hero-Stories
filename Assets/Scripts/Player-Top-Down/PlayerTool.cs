using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTool : MonoBehaviour
{
    
    public GameObject defaultButton;
    public GameObject lootButton;
    public GameObject shopButton;
    public GameObject tradeButton;
    public GameObject speechButton;
    public GameObject fixButton;


    void Start()
    {
        
    }

     private void OnTriggerEnter2D(Collider2D Collision)
	{
		if (Collision.CompareTag("Wood"))
		{
            defaultButton.SetActive(false);
            shopButton.SetActive(true);
            
		}
		else if (Collision.CompareTag("Trade"))
		{
            defaultButton.SetActive(false);
            tradeButton.SetActive(true);
		}
		else if (Collision.CompareTag("Loot"))
		{
            defaultButton.SetActive(false);
            lootButton.SetActive(true);
		}
		else if (Collision.CompareTag("NPC"))
		{
            defaultButton.SetActive(false);
            speechButton.SetActive(true);
		}
		else if (Collision.CompareTag("Repair"))
		{
            defaultButton.SetActive(false);
            fixButton.SetActive(true);
		}

	}

     private void OnTriggerExit2D(Collider2D Collision)
	{
		if (Collision.CompareTag("Wood"))
		{
            shopButton.SetActive(false);
            defaultButton.SetActive(true);
		}
		else if (Collision.CompareTag("Trade"))
		{
            tradeButton.SetActive(false);
            defaultButton.SetActive(true);
		}
		else if (Collision.CompareTag("Loot"))
		{
            lootButton.SetActive(false);
            defaultButton.SetActive(true);
		}
		else if (Collision.CompareTag("NPC"))
		{
            speechButton.SetActive(false);
            defaultButton.SetActive(true);
		}

	}
}
