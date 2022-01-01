using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int spd = 10;
    public GameObject arrow;

    void Update()
    {
        Mov();
        RestrictArea();
        ShotArrow();
    }

    // Trecho responsável por gerenciar o tiro dos projéteis
    void ShotArrow() 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            Instantiate(arrow, transform.position, Quaternion.identity);
    }

    // Trecho responsável por gerenciar o movimento do player
    void Mov() 
    {
        float hrz, vrt;

        // Eixo x
        hrz = Input.GetAxis("Horizontal") * spd * Time.deltaTime;
        // Eixo y
        vrt = Input.GetAxis("Vertical") * spd * Time.deltaTime;
        

        transform.Translate(hrz, vrt, 0);
    }

    // Trecho responsável por limitar a área de movimento do player
    void RestrictArea() 
    {
        float xPos, yPos;

        if (transform.position.x <= -5.8f || transform.position.x >= 5.8f) 
        {
            xPos = Mathf.Clamp(transform.position.x, -5.8f, 5.8f);
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }

        if (transform.position.y <= -4.5f || transform.position.y >= -2.8f) 
        {
            yPos = Mathf.Clamp(transform.position.y, -4.5f, -2.8f);
            transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
        }
    }
}
