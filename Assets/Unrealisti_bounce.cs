using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Unrealisti_bounce : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 20;
        rb.velocity = rb.velocity.normalized * speed;
    }
}
