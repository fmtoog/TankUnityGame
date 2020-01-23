using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject arch;
   void OnCollisionEnter(Collision bullet)
   {
       if (bullet.gameObject.tag == "Bullet") 
       {
           Destroy(gameObject);
           Instantiate(arch); 
       }
     
   }
}
