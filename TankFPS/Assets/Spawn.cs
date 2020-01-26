using System.Collections;
using System.Collections.Generic;
using static System.Random; 
using UnityEngine;
//Ruben
public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;

    
    private int num; 
    
   
    void Start()
    {
        num = Random.Range(1,4);
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
        
        
    }

    
}
