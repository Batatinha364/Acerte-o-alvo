using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target1Script : MonoBehaviour
{
    private bool moveRight = true;

    public float spd = 9f;
    public Transform target1A;
    public Transform target1B;

    void Update()
    {
        if (transform.position.x > target1B.position.x)
            moveRight = true;
        if (transform.position.x < target1A.position.x)
            moveRight = false;

        if (moveRight)
            transform.position = new Vector2(transform.position.x - spd * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x + spd * Time.deltaTime, transform.position.y);
    }
}
