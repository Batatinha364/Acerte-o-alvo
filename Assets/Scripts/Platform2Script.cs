using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2Script : MonoBehaviour
{
    private bool moveRight = true;

    public float spd = 5f;
    public Transform platform2A;
    public Transform platform2B;
 
    void Update()
    {
        /*
            Nesse trecho é gerenciado o movimento da plataforma
         */

        if (transform.position.x > platform2B.position.x)
            moveRight = true;
        if (transform.position.x < platform2A.position.x)
            moveRight = false;

        if (moveRight)
            transform.position = new Vector2(transform.position.x - spd * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x + spd * Time.deltaTime, transform.position.y);
    }
}
