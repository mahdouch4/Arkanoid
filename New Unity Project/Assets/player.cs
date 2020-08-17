using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float movespeed = 15.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(v,0) * movespeed;
    }
}
