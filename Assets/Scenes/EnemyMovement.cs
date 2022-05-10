using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private const float MAX_LEFT = -8.3f;
    private const float MAX_RIGHT = 8.3f;
    private int alienSpeed = 1;
    private bool moveDir = true;
    void Start()
    {
        
    }

    void Update()
    {
        if (moveDir == true)
        {
            MoveRight();
        }
        if (moveDir == false)
        {
            MoveLeft();
        }

        if (transform.position.x > MAX_RIGHT)
        {
            moveDir = false;

           
        }
        if (transform.position.x < MAX_LEFT)
        {
            moveDir = true;
        }
        
    }

    void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * alienSpeed);
    }
    void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * alienSpeed);
    }
}
