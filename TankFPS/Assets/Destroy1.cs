using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Ruben, not used
public class Destroy1 : MonoBehaviour
{
 

    
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall") 
        {
            Destroy(gameObject);
            Debug.Log("Hit");
 
        }
        if (collision.gameObject.tag == "Player2") 
        {
            Destroy(gameObject);
            //Debug.Log("Hit");
 
        }
    }
       
    
}