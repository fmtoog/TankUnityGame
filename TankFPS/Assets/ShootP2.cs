﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Ruben
public class ShootP2 : MonoBehaviour
{
    public GameObject Shooter;

    
    public GameObject Bullet;

    
    public float Bullet_Speed;
    
    private GameObject Temporary_Bullet_Handler;

    // Update is called once per frame
    void Update ()
    {
        
        if (Input.GetKeyDown("m"))
        {
            
            //Debug.Log("fired");
            Temporary_Bullet_Handler = Instantiate(Bullet,Shooter.transform.position,Shooter.transform.rotation) as GameObject;

            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);
            Temporary_Bullet_Handler.transform.Rotate((Vector3.down*90));

            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            for (int i = 0; i < 2000; i++)
            {
                //Temporary_RigidBody.AddForce(0 , 0, Bullet_Speed);    
            }
            
            
           
            
            
            
            
            Temporary_RigidBody.velocity = Temporary_RigidBody.transform.TransformDirection(0, 0, Bullet_Speed * 10);
        
            
            Destroy(Temporary_Bullet_Handler, 10.0f);
            
        }
        
        
     
    }
   
    
}

