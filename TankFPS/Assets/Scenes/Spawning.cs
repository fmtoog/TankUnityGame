using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnPos;
    public GameObject spawnee;
    public int maxX = 100;
    public int minX = -100;
    public int maxY = 10;
    public int minY = 10;
    public int maxZ = 100;
    public int minZ = -100;

    public int minSpawntime = 1;
    public int maxSpawntime = 3;
    public int spawntime = 2;
    private float time = 0;


    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >=spawntime)
        {
            time = 0;
            spawntime = RandomNumber(minSpawntime, maxSpawntime);
            Vector3 position;
            position = new Vector3(RandomNumber(minX, maxX), RandomNumber(minY,maxY), RandomNumber(minZ, maxZ));
            Instantiate(spawnee,  position, spawnPos.rotation);
            Debug.Log(position);
        }
    }

    public int RandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }
}
