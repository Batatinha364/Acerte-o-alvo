using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target2Script : MonoBehaviour
{
    private bool moveRight = true;

    public float spd = 6f;
    public Transform target2A;
    public Transform target2B;
    
    void Update()
    {
        if (transform.position.x > target2B.position.x)
            moveRight = true;
        if (transform.position.x < target2A.position.x)
            moveRight = false;

        if (moveRight)
            transform.position = new Vector2(transform.position.x - spd * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x + spd * Time.deltaTime, transform.position.y);
    }
}
