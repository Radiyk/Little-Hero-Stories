using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseOfItem : MonoBehaviour
{

    public static UseOfItem instance;
    public GameObject defaultSpeech;
    public bool apply;

    private Animator animator;

    void Start()
    {
        instance = this;
        animator = GetComponent<Animator>();
    }

    public void Use(Item item)
    {
        switch (item.name)
        {
            case "Wood":
                if (apply == true)
                {
                   Debug.Log("Wood");

                }
                else
                {
                    DefaultWindow();
                }
                break;

            case "Karta":
                Debug.Log("Karta");
                break;
            
            
        }
    }

    private void DefaultWindow()
    {
        defaultSpeech.SetActive(true);
        animator.SetTrigger("defSpeeh");
    }
}
