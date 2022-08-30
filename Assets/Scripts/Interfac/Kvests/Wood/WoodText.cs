using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodText : MonoBehaviour
{
  public static int woodForMost;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

   
    void Update()
    {
        text.text = woodForMost.ToString();
    }
}
