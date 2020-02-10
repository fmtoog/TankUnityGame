using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEditor.Experimental;
using UnityEngine;
//Ruben, used the unity docs for raycast
public class ShootP2 : MonoBehaviour
{
    public GameObject Shooter;

    
    public LineRenderer laserLineRenderer;
    public float laserWidth = 0.1f;
    

    private static int count;
    public TrailRenderer tr;
    private Material emmat;
        
    

    void Start() {
        Vector3[] initLaserPositions = new Vector3[1] {Shooter.transform.position};
        laserLineRenderer.SetPositions( initLaserPositions );
        laserLineRenderer.positionCount = 2;
        laserLineRenderer.SetWidth( laserWidth, laserWidth );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
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
            Respawn2.count = count;
            count = 0; 
        }
        if (count == 1)
        {

            emmat = tr.material;
            emmat.SetColor("_EmissionColor", Color.red);
        }
        else
        {
            emmat.SetColor("_EmissionColor",  Color.green);
        }
       
    }
    void Shoot()
    {
 
        RaycastHit hit;
        
        if (Physics.Raycast(Shooter.transform.position, Shooter.transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(Shooter.transform.position, Shooter.transform.TransformDirection(Vector3.down) * hit.distance, Color.green,1f);
            Debug.Log("Did Hit");
 
            Debug.Log(hit.transform.name);
            
            laserLineRenderer.SetPosition(0, Shooter.transform.position);
            laserLineRenderer.SetPosition(1, hit.point);
            if (hit.transform.tag == "BreakWall")
            {
                Destroy(hit.transform.gameObject);
            }


            if (hit.transform.tag == "Player")
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