using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public CapsuleCollider CapCollider;
    public GameObject TankAtk;
    public GameObject TankDef;
    public Rigidbody rb;
    public float velocity;    


    // Start is called before the first frame update
    private void BecomeSolid ()
    {
        CapCollider.enabled = true;
    }
    // returns force on the X axis which results in force equal to velocity
    private float getForceX()
    {
        float finalForceX = 0;
        float rotX;
        rotX = TankAtk.transform.rotation.x + 90;
        if (rotX == 0)
        {
            return velocity;
        }
        else if (rotX < 90 & rotX > -90)
        {
            finalForceX = velocity * Mathf.Cos(rotX);
        }
        else
        {
            finalForceX = velocity * Mathf.Cos(rotX);
            finalForceX = -finalForceX;
        }

        return(finalForceX);
    }

    // returns force on the Z axis which results in force equal to velocity
    private float getForceZ()
    {
        float finalForceZ = 0;
        float rotZ;
        rotZ = TankAtk.transform.rotation.z;
        if (rotZ == 0)
        {
            return velocity;
        }
        else if (rotZ < 90 & rotZ > -90)
        {
            finalForceZ = velocity * Mathf.Cos(rotZ);
        }

        else
        {
            finalForceZ = velocity * Mathf.Cos(rotZ);
            finalForceZ = -finalForceZ;
        }
        return (finalForceZ);
    }

    // returns force on the Y axis which results in force equal to velocity
    private float getForceY()
    {
        float finalForceY = 0;
        float rotY;
        rotY = TankAtk.transform.rotation.y;
        if (rotY == 0)
        {
            return velocity;
        }
        else if (rotY < 90 & rotY > -90)
        {
            finalForceY = velocity * Mathf.Cos(rotY);
        }
        else
        {
            finalForceY = velocity * Mathf.Cos(rotY);
            finalForceY = -finalForceY;
        }
        return (finalForceY);
    }


    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f"))
        {
            //instantiate bullet (properties)
            transform.SetPositionAndRotation(TankAtk.transform.position, TankAtk.transform.rotation);
            //transform.Rotate(90, 0, 0);
            rb.velocity = transform.up * velocity * Time.deltaTime;
            Invoke("BecomeSolid", 0.5f);
        }
    }
}
