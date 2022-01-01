using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PTScript : MonoBehaviour
{
    public Text PTUI;
    public Text PTMaxUI;
    public int PT = 8;
    public GameObject player;

    void Update()
    {
        if (PT > PlayerPrefs.GetInt("PontMax"))
            PlayerPrefs.SetInt("PontMax", PT);
        

        PTUI.text = "Pont: " + PT;
        PTMaxUI.text = "Pont. M�x: " + PlayerPrefs.GetInt("PontMax");

        if (PT <= 0) 
        {
            PTUI.text = "Sua pontua��o zerou!";
            PTMaxUI.text = "Pont. M�x: " + PlayerPrefs.GetInt("PontMax");
            Destroy(player);

            if (Input.anyKey)
                SceneManager.LoadScene("Menu");
        }
    }
}
