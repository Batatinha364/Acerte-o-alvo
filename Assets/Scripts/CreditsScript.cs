using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Script da cena de cr�ditos

public class CreditsScript : MonoBehaviour
{
    public void OnReturn() 
    {
        SceneManager.LoadScene("Menu");
    }
}
