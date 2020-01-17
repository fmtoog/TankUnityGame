using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour
{
    private Vector3 lastPos;
    public float wheelRadius = 1; // you need to set this based on your model
    private Transform child; // your visual mesh should be the first child of this object
    void Start()
    {
        lastPos = transform.position;
        child = transform.GetChild(0);
    }
    void Update()
    {
        Vector3 movement = transform.position - lastPos;
        float distance = Vector3.Dot(movement, transform.forward);
        float spin = (distance / (2f * Mathf.PI * wheelRadius)) * 360f;
        child.Rotate(new Vector3(-spin, 0, 0)); // assuming your wheel models are facing z-forward, y-up
        lastPos = transform.position;
    }
}
