using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public float velocity = 20.0f;
    [SerializeField] public Rigidbody2D rb;
    int damage = 20;

    void Start()
    {
        rb.velocity = transform.right * velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SquareEnemy enemy = collision.GetComponent<SquareEnemy>();

        if(enemy != null)
        {
            enemy.TakeDamate(damage);
        }

        Destroy(gameObject);
    }

}
