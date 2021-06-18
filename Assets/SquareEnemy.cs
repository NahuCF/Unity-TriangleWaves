using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareEnemy : MonoBehaviour
{
    public int health = 40;

    void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamate(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }
}
