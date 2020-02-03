using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 //Ruben

public class Respawn2 : MonoBehaviour
{
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;

    //GW
    public GameObject DistanceControl;
    public GameObject Player1;
    
    //GW
    public int P1kills = 0;
    public Text P2text;
    public GameObject Pannel;

    private int count = 0;
    private int num = 0;

    private void Start()
    {
        num = UnityEngine.Random.Range(1, 4); 
        Debug.Log(num + "num");
        P2text.text = "0";
        Pannel.GetComponent<Image>().enabled = false;
    }


    void OnCollisionEnter(Collision bullet)
    {
        if (bullet.gameObject.tag == "Bullet2")
        {
            Destroy(bullet.gameObject);
            count += 1; 
            Debug.Log("hit" + gameObject);
            Debug.Log(count + "count" + gameObject);
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
            P1kills = P1kills + 1;
            P2text.text = P1kills.ToString();
            DistanceControl.GetComponent<Distance>().distance2 = 0;
            Player1.GetComponent<TrailRenderer>().time = Player1.GetComponent<TrailRenderer>().time + 1.5f;
            Pannel.GetComponent<Image>().enabled = true;
            Invoke("hide", 1.5f);


        }
        
    }
}

