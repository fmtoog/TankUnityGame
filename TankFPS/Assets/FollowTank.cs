using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //player position
    public Transform player;

    // offset behind player
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // move camera to player position
        transform.position = player.position + offset;
    }
}
