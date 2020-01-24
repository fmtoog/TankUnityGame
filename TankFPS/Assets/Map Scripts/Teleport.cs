using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Teleport : MonoBehaviour //ruben
{
    public GameObject end;
    public bool tel;
    private Vector3 startposition;
    private Vector3 endposition;
    private Vector3 cammove;
    public Vector3 displacment = new Vector3(-5f, 0f, 0f);

     bool Pause()
    {
        return tel = true;
       
    }
    
    
    void OnTriggerEnter(Collider tank)
    {
        
        if (tel == true)
        {
            startposition = tank.transform.position;
            
         
            if (tank.transform.tag == "Player")
            {
                endposition = end.transform.position + displacment;
                tank.transform.position = endposition;
                cammove = tank.transform.position - startposition;
                Camera.main.transform.position += cammove;
                tel = false;
                Invoke("Pause", 5f);
                
            }
        }
    }
    



}
