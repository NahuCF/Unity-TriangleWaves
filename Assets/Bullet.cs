using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public float velocity = 20.0f;
    [SerializeField] public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * velocity;
    }

}
