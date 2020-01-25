using UnityEngine;


public class distance : MonoBehaviour
{
    public float distance1;
    
    public Transform player1;

    private Vector3 lastposition;

    public void Reset()
    {
        distance1 = 0;
    }


    void Start()
    {
        lastposition = player1.position;

        Invoke("Reset", 1.5f);
    }
    void Update()
    {
        

        distance1 += Vector3.Distance(player1.position, lastposition);
        lastposition = player1.position;
    }
    void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 1000, 200), distance1.ToString());
        
    }
}