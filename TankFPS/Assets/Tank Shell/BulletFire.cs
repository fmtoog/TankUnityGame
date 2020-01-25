using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public CapsuleCollider CapCollider;
    public GameObject TankAtk;
    public GameObject TankDef;
    public Rigidbody rb;
    public float velocity;
    public bool Fired = false;
    

    // Start is called before the first frame update
    private void BecomeSolid ()
    {
        CapCollider.enabled = true;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Fired == false)
        {
            transform.SetPositionAndRotation(TankAtk.transform.position, TankAtk.transform.rotation);
            
            if (Input.GetKey("f"))
            {
                Fired = true;
                
                //transform.Rotate(90, 0, 0);
                //rb.velocity = transform.up * velocity * Time.deltaTime;
                
            }
        }
    }
}
