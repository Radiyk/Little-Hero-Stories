using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hungry : MonoBehaviour
{
    public float currentHungry = 100;

    public float timeToHungry;

    private float minHungry = 5;

    public GameObject canvas;

    private Animator animator;

    Slider slider;

    Text scoreView;
    private  int hungerScore;

    void Start()
    {
        animator = canvas.GetComponent<Animator>();

        slider = GetComponent<Slider>();
        StartCoroutine(hungryTime(1));

        scoreView = transform.GetChild(5).GetComponent<Text>();
    }

   
    
    void Update()
    {
        
        if(currentHungry <= minHungry)
        {
            AttentionBar();
        }

        scoreView.text = hungerScore.ToString();
    }


    IEnumerator hungryTime(float hang)
    {
        while (currentHungry >= minHungry)
        {
            yield return new WaitForSeconds(timeToHungry);
            currentHungry -= hang;
            slider.value = currentHungry;
            hungerScore -= 1;
        }
        
    }

    private void AttentionBar ()
    {
        PlayerTopDownControl.Speed =1;
        animator.SetTrigger("isHungry");
    }
}
