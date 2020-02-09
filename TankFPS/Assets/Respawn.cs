using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 //Ruben

public class Respawn : MonoBehaviour
{
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;


    public static int count = 0;

    //GW
    public GameObject DistanceControl;
    public GameObject Player2;
    public GameObject Pannel;

    //GW
    public int P2kills = 0;
    public Text P1text;

    

    private int num = 0;

    private void Start()
    {
        num = UnityEngine.Random.Range(1, 4); 
        Debug.Log(num + "num");
        Pannel.GetComponent<Image>().enabled = false;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            count += 2;
        }
    }

    

    private void hide()
    {
        Pannel.GetComponent<Image>().enabled = false;
    }

    private void Update()
    {
        if (count == 2)
        {
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

            count = 0;

            //GW
            P2kills = P2kills + 1;
            P1text.text = P2kills.ToString();
            DistanceControl.GetComponent<Distance>().distance1 = 0;
            Player2.GetComponent<TrailRenderer>().time = Player2.GetComponent<TrailRenderer>().time + 1.5f;
            Pannel.GetComponent<Image>().enabled = true;
            Invoke("hide", 1.5f);

        }
        
    }
}
