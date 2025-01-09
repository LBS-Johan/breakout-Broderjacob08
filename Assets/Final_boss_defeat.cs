using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final_boss_defeat : MonoBehaviour
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
        SceneManager.LoadScene (2);
    }
}
