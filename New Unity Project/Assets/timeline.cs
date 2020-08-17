using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class timeline : MonoBehaviour
{
    int x;
    public float movespeedttime = 1;
    public Text time; 
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movespeedttime;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        time.text = transform.position.y.ToString("0");
    }
}

