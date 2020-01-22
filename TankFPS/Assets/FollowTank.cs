using UnityEngine;

public class FollowTank : MonoBehaviour
{
    //player position
    public Transform player;
    public GameObject Tank;

    // offset behind player
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // move camera to player position
        transform.position = player.position + offset;
        transform.LookAt(player);

        transform.LookAt(player);
    }

}
