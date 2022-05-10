using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D Rigidbody2D;

    void Start()
    {
        Rigidbody2D.velocity = transform.up * speed;
    }

    private void Update()
    {
        Destroy(this.gameObject,2);
    }
}
