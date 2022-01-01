using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Script da cena de menu

public class MenuScript : MonoBehaviour
{
    public void OnStart() 
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnExit() 
    {
        Application.Quit();
    }

    public void OnCredits() 
    {
        SceneManager.LoadScene("Credits");
    }
}
