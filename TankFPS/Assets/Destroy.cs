using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
 

    
    
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Wall") 
            {
                Destroy(gameObject);
                Debug.Log("Hit");
 
            }
            if (collision.gameObject.tag == "Player") 
            {
                Destroy(gameObject);
                Debug.Log("Hit");
 
            }
        }
       
    
}
