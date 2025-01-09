using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity_ball_bounce : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 20;
        rb.velocity = rb.velocity.normalized * speed;
    }
}
