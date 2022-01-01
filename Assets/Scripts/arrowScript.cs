using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowScript : MonoBehaviour
{
    public float spd = 5;
    private PTScript PTScriptArrow;
    public AudioClip PlatfSE;
    public AudioClip TgSE;
    public AudioClip ArrowSE;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D> ();
        rb.velocity = new Vector2(0, spd);
        PTScriptArrow = GameObject.Find("PT").GetComponent<PTScript>();
        AudioSource.PlayClipAtPoint(ArrowSE, transform.position, 1f);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D elem) 
    {
        /*
            Nesse trecho é gerenciado as colisões do projétil
         */

        if(elem.gameObject.tag == "platf") 
        {
            PTScriptArrow.PT -= 2;
            AudioSource.PlayClipAtPoint(PlatfSE, transform.position, 1f);
            Destroy(gameObject);
        }
        else if(elem.gameObject.tag == "tg3") 
        {
            PTScriptArrow.PT += 1;
            AudioSource.PlayClipAtPoint(TgSE, transform.position, 1f);
            Destroy(gameObject);
        }
        else if (elem.gameObject.tag == "tg2") 
        {
            PTScriptArrow.PT += 2;
            AudioSource.PlayClipAtPoint(TgSE, transform.position, 1f);
            Destroy(gameObject);
        }
        else if (elem.gameObject.tag == "tg1") 
        {
            PTScriptArrow.PT += 4;
            AudioSource.PlayClipAtPoint(TgSE, transform.position, 1f);
            Destroy(gameObject);
        }
    }
}
