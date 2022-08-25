using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDownControl : MonoBehaviour
{
    public static float Speed = 3;
    public ControlType controlType;
    public Joystick joystick;
    private float moveInputY, moveInputX;

    public enum ControlType { PC, Android }

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;

    private AudioSource MyAudioSource;
    public AudioClip[] AudioClips;
    private AudioClip showMoney;

    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        MyAudioSource = GetComponent<AudioSource>();

        showMoney = MyAudioSource.clip = AudioClips[0];
    }


    void Update()
    {
        if (controlType == ControlType.PC)
        {
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        }

        else if (controlType == ControlType.Android)
        {
            moveInputX = joystick.Horizontal * Speed;
            moveInputY = joystick.Vertical * Speed;

        }
        //moveVelocity = moveInput.normalized * Speed;

        
            if (Math.Abs(moveInputY) > Math.Abs(moveInputX)) 
            { // Y
                if(moveInputY > 0) 
                { // вверх
                    animator.SetBool("Up", true);
                    animator.SetBool("Right", false);
                    animator.SetBool("Down", false);
                    animator.SetBool("Left", false);
                } 
                if(moveInputY < 0)
                { // вниз
                    animator.SetBool("Down", true);
                    animator.SetBool("Up", false);
                    animator.SetBool("Right", false);
                    animator.SetBool("Left", false);
                }
            }else if (Math.Abs(moveInputY) < Math.Abs(moveInputX))
            {

                if(moveInputX < 0)
                { // влево
                    animator.SetBool("Left", true);
                    animator.SetBool("Up", false);
                    animator.SetBool("Down", false);
                    animator.SetBool("Right", false);
                }
                if(moveInputX > 0)
                { // вправо
                    animator.SetBool("Right", true);
                    animator.SetBool("Up", false);
                    animator.SetBool("Down", false);
                    animator.SetBool("Left", false);
                }
            }else if (moveInputY ==0 && moveInputX ==0)
            {    //стоит
                animator.SetBool("Default", false);
                animator.SetBool("Right", false);
                animator.SetBool("Up", false);
                animator.SetBool("Down", false);
                animator.SetBool("Left", false);
            }
          
        
        
    }

    public void ShowMoney()
    {
        animator.SetTrigger("MoneyShow");
        MyAudioSource.PlayOneShot(showMoney);
    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInputX, moveInputY);
    }

   
}
