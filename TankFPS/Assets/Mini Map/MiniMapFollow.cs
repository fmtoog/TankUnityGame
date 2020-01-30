using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public GameObject TankToFollow;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(TankToFollow.transform.position.x, TankToFollow.transform.position.y + offset, TankToFollow.transform.position.z);
    }
}
