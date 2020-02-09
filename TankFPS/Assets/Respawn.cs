using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 //Ruben

public class Respawn : MonoBehaviour
{
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;

    public static int count = 0;
    private int num = 0;

    private void Start()
    {
        num = UnityEngine.Random.Range(1, 4); 
        Debug.Log(num + "num");
    }


    

    private void Update()
    {
        if (count == 2)
        {
            if (num == 1)
            {
                gameObject.transform.position = Spawn1.transform.position;
            }
            if (num == 2)
            {
                gameObject.transform.position = Spawn2.transform.position;
            }
            if (num == 3)
            {
                gameObject.transform.position = Spawn3.transform.position;
            }
            if (num == 4)
            {
                gameObject.transform.position = Spawn4.transform.position;
            }

            count = 0; 
        }
        
    }
}
