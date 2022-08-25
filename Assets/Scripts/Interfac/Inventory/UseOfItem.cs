using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseOfItem : MonoBehaviour
{
    public static UseOfItem instance;

    void Start()
    {
        instance = this;
    }

    public void Use(Item item)
    {
        switch (item.name)
        {
            case "Wood":
                Debug.Log("Wood");
                break;

            case "Karta":
                Debug.Log("Karta");
                break;
            
            
        }
    }
}
