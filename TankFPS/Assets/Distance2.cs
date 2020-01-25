using UnityEngine;


public class Distance2 : MonoBehaviour
{
    public float distance2;

    public Transform player2;

    private Vector3 lastposition;

    public void Reset()
    {
        distance2 = 0;
    }


    void Start()
    {
        lastposition = player2.position;

        Invoke("Reset", 1.5f);
    }
    void Update()
    {


        distance2 += Vector3.Distance(player2.position, lastposition);
        lastposition = player2.position;
    }
    void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 1000, 200), distance2.ToString());

    }
}