using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

public class PlayerController : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPreFab;
    
    private const float MAX_LEFT = -8.3f;
    private const float MAX_RIGHT = 8.3f;
    private const float MAX_TOP = -0.5f;
    private const float MAX_DOWN = -4.5f;

    private float speed = 5;
    
    public float fireRate = 0.5F; 
    private float nextFire = 0.0F;

    void Update()
    {
        if (Input.GetKey(KeyCode.A) && (transform.position.x > MAX_LEFT))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D) && (transform.position.x < MAX_RIGHT))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W) && (transform.position.y < MAX_TOP))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S) && (transform.position.y > MAX_DOWN))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }
    
    void Shoot()
    {
        Instantiate(bulletPreFab, FirePoint.position, FirePoint.rotation);
    }
}
