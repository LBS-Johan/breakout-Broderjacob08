using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_direction_Wall : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        float y = Random.Range(-5, 5);
        rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(y, 3);
    }
}