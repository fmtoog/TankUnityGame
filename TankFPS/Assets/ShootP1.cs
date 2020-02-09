using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEditor;
using UnityEditor.Experimental;
using UnityEngine;
//Ruben, used the unity docs for raycast
//Ruben also designed and built map 
public class ShootP1 : MonoBehaviour
{
    public GameObject Shooter;

    
    public LineRenderer laserLineRenderer;
    public float laserWidth = 0.1f;
    public float laserMaxLength = 5f;

    private static int count;

    
 
    void Start() {
        Vector3[] initLaserPositions = new Vector3[1] {Shooter.transform.position};
        laserLineRenderer.SetPositions( initLaserPositions );
        laserLineRenderer.positionCount = 2;
        laserLineRenderer.SetWidth( laserWidth, laserWidth );
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Shoot();
            laserLineRenderer.enabled = true;
        }
        else
        {
           // Thread.Sleep(30);
            
            laserLineRenderer.enabled = false; 
        }

        if (count == 2)
        {
            Respawn.count = count;
            count = 0; 
        }
        
    }

    
    void Shoot()
    {
 
        RaycastHit hit;
        
        if (Physics.Raycast(Shooter.transform.position, Shooter.transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(Shooter.transform.position, Shooter.transform.TransformDirection(Vector3.down) * hit.distance, Color.red,1f);
            Debug.Log("Did Hit");
 
            Debug.Log(hit.transform.name);
            laserLineRenderer.SetPosition(0, Shooter.transform.position);
            laserLineRenderer.SetPosition(1, hit.point);
            
            if (hit.transform.tag == "BreakWall")
            {
                Destroy(hit.transform.gameObject);
            }

            if (hit.transform.tag == "Player2")
            {
                count += 1; 
                Debug.Log(count);
            }
 
        }
        else
        {
            Debug.DrawRay(Shooter.transform.position, Shooter.transform.TransformDirection(Vector3.down) * 1000, Color.red,2f);
            Debug.Log("Did not Hit");
        }
 
    }
     
    
}