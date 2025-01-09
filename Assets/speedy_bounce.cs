using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedy_bounce : MonoBehaviour
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
        float speed = 40;
        rb.velocity = rb.velocity.normalized * speed;
    }
}
