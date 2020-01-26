using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
//Ruben
public class Break : MonoBehaviour
{
    public GameObject arch;
   void OnCollisionEnter(Collision bullet)
   {
       if (bullet.gameObject.tag == "Bullet" || bullet.gameObject.tag == "Bullet2") 
       {
           Destroy(gameObject);
           Destroy(bullet.gameObject);
           Instantiate(arch, gameObject.transform.position, gameObject.transform.rotation); 
       }
     
   }
}
