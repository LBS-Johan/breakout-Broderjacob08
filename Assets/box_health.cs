using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_health : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 1;

    int health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void Hurt(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Destroy(gameObject);
    }
}
