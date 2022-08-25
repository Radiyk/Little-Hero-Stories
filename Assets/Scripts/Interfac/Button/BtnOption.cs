using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOption : MonoBehaviour
{
    public int btnOption;


    public void PassAnArgument()
    {
       AudioForButton.btnOptions = btnOption;  
    }

}
