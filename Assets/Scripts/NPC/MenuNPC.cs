using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNPC : MonoBehaviour
{
    public static bool present;
    public static bool danat;



    void Start()
    {
        present = false;
        danat = false;
    }

    public void Danat()
    {
        ManeyText.maney -= 100;
        danat = true;
    }

    public void Present()
    {
        AppleText.apple -= 1;
        present = true;
    }

    
}
