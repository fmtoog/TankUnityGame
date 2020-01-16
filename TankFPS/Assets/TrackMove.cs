using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour
{
    public Transform tank;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //https://answers.unity.com/questions/26856/check-object-for-motion.html
        curPos = position;
        if (curPos == lastPos)
        {
            print("Not moving");
        }
        lastPos = curPos;
    }
}
