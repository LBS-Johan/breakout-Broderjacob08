using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_damage : MonoBehaviour
{
    [SerializeField]
    int hurtAmount = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        box_health ehealth = collision.gameObject.GetComponent<box_health>();
        if (ehealth == null)
        {
            return;
        }

        ehealth.Hurt(hurtAmount);
        
    }
}

