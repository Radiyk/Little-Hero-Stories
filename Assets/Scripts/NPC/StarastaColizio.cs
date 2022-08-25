using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarastaColizio : MonoBehaviour
{
   

    private bool isTriggeretExit = false;
    private bool isTriggeretEnter = false;

    //public GameObject attention;


    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (isTriggeretEnter == false)
            {
                isTriggeretEnter = true;
            }

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (isTriggeretExit == false)
            {
               // attention.SetActive(true);
                isTriggeretExit = true;
            }

        }
    }
}
