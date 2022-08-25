using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleText : MonoBehaviour
{
    public static int apple;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        if(PlayerPrefs.HasKey("Apple"))
        {
            apple = PlayerPrefs.GetInt("Apple");
        }
    }

   
    void Update()
    {
        text.text = apple.ToString();
    }
}
