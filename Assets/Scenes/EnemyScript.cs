using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyScript : MonoBehaviour
{
    public GameObject[] Alien_1;
    public GameObject[] Alien_2;
    public GameObject[] Alien_3;

    void Start()
    {
        
        for (int i = 0;i <= 10; i++)
        {
            
            Instantiate(Alien_1[i] ,new Vector3(-5+i,1,0),Quaternion.identity);
            
            Instantiate(Alien_2[i] ,new Vector3(-5+i,2,0),Quaternion.identity);
            
            Instantiate(Alien_3[i] ,new Vector3(-5+i,3,0),Quaternion.identity);
        }
    }
}
