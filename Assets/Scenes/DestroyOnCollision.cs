using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public int wallHealth;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
        if (collision.gameObject.tag == "Wall")
        {
            wallHealth--;
            Destroy(gameObject);
            Debug.Log(wallHealth);
        }
        if (wallHealth == 0)
        {
            Debug.Log("DESTROY");
            Destroy(collision.gameObject);
        }

        
    }
}
