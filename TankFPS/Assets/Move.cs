using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
    //George Waller
    //cube game

{
    //this is referenced the the rigidbody component rb
    public Rigidbody rb;
    public GameObject tank;
    public Transform turret;
    public float speed = 5;

    //allow editing speed in inspector
    public float acceleration = 5f;
    public float rotationpower = 0.2f;
    private bool lastshift;
    public bool player1 = true;

    private KeyCode forward = KeyCode.UpArrow;
    private KeyCode backwards = KeyCode.DownArrow;
    private KeyCode left = KeyCode.LeftArrow;
    private KeyCode right = KeyCode.RightArrow;
    private KeyCode tleft = KeyCode.Comma;
    private KeyCode tright = KeyCode.Period;
    private KeyCode fire = KeyCode.Slash;

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            lastshift = true;
        }

        if (player1 == true)
        {
            forward = KeyCode.W;
            backwards = KeyCode.S;
            left = KeyCode.A;
            right = KeyCode.D;
            tleft = KeyCode.Q;
            tright = KeyCode.E;
            fire = KeyCode.F;
        }
    }

    // Update is called once per frame
    // FixedUpdate becaused it is used to interact with physics
    void FixedUpdate()
    {
        if (Input.GetKey(forward))
        //forwards / backwards movement
        //https://learn.unity.com/tutorial/tank-creation-and-control?language=en&projectId=5c5149c5edbc2a001fd5be95#5c7f8528edbc2a002053b399
        {
            Vector3 movement = transform.forward * speed * Time.deltaTime;

            // Apply this movement to the rigidbody's position.
            rb.MovePosition(rb.position + movement);

        }

        if (Input.GetKey(backwards))
        {
            Vector3 movement = -transform.forward * speed * Time.deltaTime;

            // Apply this movement to the rigidbody's position.
            rb.MovePosition(rb.position + movement);

        }

        //go right
        if (Input.GetKey(right))
        {
            tank.transform.Rotate(0f, 5f * rotationpower, 0f);
        }

        //go left
        if (Input.GetKey(left))
        {
            tank.transform.Rotate(0f, -5f * rotationpower, 0f);
        }

        //turret right
        if (Input.GetKey(tright))
        {
            turret.transform.Rotate(0f, 0f, 1.2f); 
        }

        //turret left
        if (Input.GetKey(tleft))
        {
            turret.transform.Rotate(0f, 0f, -1.2f);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
        {
            if (lastshift == true)
            {
                Vector3 movement = transform.forward * speed * 2 * Time.deltaTime;

                // Apply this movement to the rigidbody's position.
                rb.MovePosition(rb.position + movement);
            }
        }

        else
        {
            lastshift = false;
        }
        //check fallen off
        //if (rb.position.y < -1f)
        {
            //FindObjectOfType<GameManager>().EndGame();
        }



    }
}
