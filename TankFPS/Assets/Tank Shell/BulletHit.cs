using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{

    public GameObject TankAtk;
    public GameObject Tank1;
    public GameObject Tank2;
    public GameObject This;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == TankAtk)
        { }
        else 
        {


            if (collision.tag == "Player")
            {
                HitTank(collision);
            }
            else if (collision.tag == "Wall")
            {
                HitWall(collision);
            }
            else
            {
                HitFloor();
            }
        }
        
    }
    private void OnCollisionEnter (Collision collision)
        
    {
        if (collision.gameObject == TankAtk)
        { }
        else
        {
            if (collision.collider.tag == "Player")
            {
                HitTank(collision.collider);
            }
            else if (collision.collider.tag == "Wall")
            {
                HitWall(collision.collider);
            }
            else
            {
                HitFloor();
            }
        }
    }
    private void HitTank(Collider TankHit)
    {
        if (TankHit.name == "Tank1" & TankHit.name != TankAtk.name)
        {
            //Tank1.hit();
        }
        else if (TankHit.name == "Tank2" & TankHit.name != TankAtk.name)
        {
            //Tank2.hit();
        }
        Destroy(This, 1);
    }
    private void HitWall(Collider WallHit)
    {
        //WallHit.hit();
        Destroy(This, 1);
    }
    private void HitFloor()
    {
        Destroy(This, 1);
    }
}
