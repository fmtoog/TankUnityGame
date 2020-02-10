//GW
﻿using UnityEngine;


public class Distance : MonoBehaviour
{
    public float distance1;
    public float distance2;

    public Transform player1;
    public Transform player2;

    public GameObject P1;
    public GameObject P2;

    private Vector3 lastposition1;
    private Vector3 lastposition2;

    public void Reset()
    {
        distance1 = 0;
        distance2 = 0;
    }


    void Start()
    {
        lastposition1 = player1.position;
        lastposition2 = player2.position;

        Invoke("Reset", 1.5f);
    }
    void Update()
    {


        distance1 += Vector3.Distance(player1.position, lastposition1);
        lastposition1 = player1.position;

        distance2 += Vector3.Distance(player2.position, lastposition2);
        lastposition2 = player2.position;

        if (distance1 >= 80)
        {
            P1.GetComponent<Move>().speed = P1.GetComponent<Move>().speed + 0.35f;
            P1.GetComponent<Move>().rotationpower = P1.GetComponent<Move>().rotationpower + 0.07f;
            distance1 = 0;
        }

        if (distance2 >= 80)
        {
            P2.GetComponent<Move>().speed = P2.GetComponent<Move>().speed + 0.35f;
            P2.GetComponent<Move>().rotationpower = P2.GetComponent<Move>().rotationpower + 0.07f;
            distance2 = 0;
        }

    }
    void OnGUI()
    {
        //GUI.Label(new Rect(100, 100, 1000, 200), distance1.ToString());
        //GUI.Label(new Rect(1000, 100, 1000, 200), distance2.ToString());

    }
}