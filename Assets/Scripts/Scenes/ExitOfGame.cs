using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitOfGame : MonoBehaviour
{
    
    public void Exit ()
    {
       // Application.Quit();
        SceneManager.LoadScene(0);
    }
    

    
}
