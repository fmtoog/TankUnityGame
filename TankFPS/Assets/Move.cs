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

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            lastshift = true;
        }
    }

    // Update is called once per frame
    // FixedUpdate becaused it is used to interact with physics
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        //forwards / backwards movement
        //https://learn.unity.com/tutorial/tank-creation-and-control?language=en&projectId=5c5149c5edbc2a001fd5be95#5c7f8528edbc2a002053b399
        {
            Vector3 movement = transform.forward * speed * Time.deltaTime;

            // Apply this movement to the rigidbody's position.
            rb.MovePosition(rb.position + movement);

        }

        if (Input.GetKey("s"))
        {
            Vector3 movement = -transform.forward * speed * Time.deltaTime;

            // Apply this movement to the rigidbody's position.
            rb.MovePosition(rb.position + movement);

        }

        //go right
        if (Input.GetKey("d"))
        {
            tank.transform.Rotate(0f, 5f * rotationpower, 0f);
        }

        //go left
        if (Input.GetKey("a"))
        {
            tank.transform.Rotate(0f, -5f * rotationpower, 0f);
        }

        //turret right
        if (Input.GetKey("e"))
        {
            turret.transform.Rotate(0f, 0f, 1.2f); 
        }

        //turret left
        if (Input.GetKey("q"))
        {
            turret.transform.Rotate(0f, 0f, -1.2f);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w"))
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
