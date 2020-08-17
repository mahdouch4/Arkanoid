using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float ballspeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * ballspeed;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos,
         float racketHeight)
    {

        return (ballPos.y - racketPos.y) / racketHeight;
    }

    public float Ballmovespeed = 20f;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Racket")
        {

            float x = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);


            Vector2 dir = new Vector2(x, 1).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * Ballmovespeed;
        }

       
    }
}

