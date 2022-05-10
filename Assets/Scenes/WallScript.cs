using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public GameObject[] Wall;
    
    void Start()
    {
        Instantiate(Wall[0], new Vector3(-6 , -2, 0), Quaternion.identity);
        Instantiate(Wall[1], new Vector3(-2 , -2, 0), Quaternion.identity);
        Instantiate(Wall[2], new Vector3(2 , -2, 0), Quaternion.identity);
        Instantiate(Wall[3], new Vector3(6 , -2, 0), Quaternion.identity);
    }
    
    void Update()
    {
        
    }
}
