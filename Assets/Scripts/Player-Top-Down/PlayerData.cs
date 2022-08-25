using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{

    private Transform position;

    public float x, y;


    void Start()
    {
        position = GetComponent<Transform>();
        Load();
    }

   

    void Update()
    {
        x = position.transform.position.x;
        y = position.transform.position.y;
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("X", x);
        PlayerPrefs.SetFloat("Y", y);
    }

    private void Load()
    {
        if (PlayerPrefs.HasKey("X"))
        {
            x = PlayerPrefs.GetFloat("X");
        }
        if (PlayerPrefs.HasKey("Y"))
        {
            y = PlayerPrefs.GetFloat("Y");
        }

        position.transform.position = new Vector2(x, y);
    }
}
