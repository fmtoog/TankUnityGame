﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 //Ruben

public class Respawn : MonoBehaviour
{
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;

    //GW
    public GameObject DistanceControl;
    public GameObject Player2;

    //GW
    public int P2kills = 0;
    public Text P1text;

    private int count = 0;
    private int num = 0;

    private void Start()
    {
        num = UnityEngine.Random.Range(1, 4); 
        Debug.Log(num + "num");
    }


    void OnCollisionEnter(Collision bullet)
    {
        if (bullet.gameObject.tag == "Bullet")
        {
            Destroy(bullet.gameObject);
            count += 1; 
            Debug.Log("hit" + gameObject);
            Debug.Log(count + "count" + gameObject);
        }
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

            //GW
            P2kills = P2kills + 1;
            P1text.text = P2kills.ToString();
            DistanceControl.GetComponent<Distance>().distance1 = 0;
            Player2.GetComponent<TrailRenderer>().time = Player2.GetComponent<TrailRenderer>().time + 1.5f;

        }
        
    }
}
