using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target3Script : MonoBehaviour
{
    private bool moveRight = true;

    public float spd = 4f;
    public Transform target3A;
    public Transform target3B;

    void Update()
    {
        if (transform.position.x > target3B.position.x)
            moveRight = true;
        if (transform.position.x < target3A.position.x)
            moveRight = false;

        if (moveRight)
            transform.position = new Vector2(transform.position.x - spd * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x + spd * Time.deltaTime, transform.position.y);
    }
}
