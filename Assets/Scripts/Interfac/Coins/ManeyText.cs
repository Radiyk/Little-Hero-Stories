using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManeyText : MonoBehaviour
{
    public static int maney;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        if(PlayerPrefs.HasKey("Maney"))
        {
            maney = PlayerPrefs.GetInt("Maney");
        }
    }

   
    void Update()
    {
        text.text = maney.ToString();
    }
}
