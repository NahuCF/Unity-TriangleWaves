using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] public Transform firePoint;
    [SerializeField] public GameObject bullet;
    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
}
