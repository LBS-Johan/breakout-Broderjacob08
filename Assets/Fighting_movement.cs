using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Fighting_movement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Xspeed = 0;
        float Yspeed = rb.velocity.y;
        
        
        if (Input.GetKey(KeyCode.D)) 
        {
            Xspeed = 50;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Xspeed = -50;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Yspeed = 50;
        }

        rb.velocity = new Vector2(Xspeed, Yspeed);
    }
}
