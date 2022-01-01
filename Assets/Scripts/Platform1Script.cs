using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform1Script : MonoBehaviour
{
    private bool moveRight = true;

    public float spd = 3f;
    public Transform platform1A;
    public Transform platform1B;

    void Update()
    {
        /*
            Nesse trecho é gerenciado o movimento da plataforma
         */

        if (transform.position.x > platform1B.position.x)
            moveRight = true;
        if (transform.position.x < platform1A.position.x)
            moveRight = false;

        if (moveRight)
            transform.position = new Vector2(transform.position.x - spd * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x + spd * Time.deltaTime, transform.position.y);
        
    }
}
