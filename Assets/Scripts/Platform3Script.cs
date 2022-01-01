using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform3Script : MonoBehaviour
{
    private bool moveRight = true;

    public float spd = 7f;
    public Transform platform3A;
    public Transform platform3B;

    void Update()
    {
        /*
            Nesse trecho é gerenciado o movimento da plataforma
         */

        if (transform.position.x > platform3B.position.x)
            moveRight = true;
        if (transform.position.x < platform3A.position.x)
            moveRight = false;

        if (moveRight)
            transform.position = new Vector2(transform.position.x - spd * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x + spd * Time.deltaTime, transform.position.y);
    }
}
