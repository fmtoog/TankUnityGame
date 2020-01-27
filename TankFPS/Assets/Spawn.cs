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
    public GameObject Player1;
    public GameObject Player2;

    
    private int num;
    private int num1; 
    
   
    void Start()
    {
        num = Random.Range(1,4);
        if (num == 1)
        {
            Player1.transform.position = Spawn1.transform.position;
            Player2.transform.position = Spawn3.transform.position;
        }
        if (num == 2)
        {
            Player1.transform.position = Spawn2.transform.position;
            Player2.transform.position = Spawn4.transform.position;
        }
        if (num == 3)
        {
            Player1.transform.position = Spawn3.transform.position;
            Player2.transform.position = Spawn1.transform.position;
        }
        if (num == 4)
        {
            Player1.transform.position = Spawn4.transform.position;
            Player2.transform.position = Spawn2.transform.position;
        }
        
        
    }

    
}
