using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup1 : MonoBehaviour
{
    public GameObject spawnee;
    public GameObject tank1;
    public GameObject tank2;


    public int maxX = 100;
    public int minX = -100;
    public int maxY = 10;
    public int minY = 1;
    public int maxZ = 100;
    public int minZ = -100;
    public bool stillKill = true;

    public int minSpawntime = 10;
    public int maxSpawntime = 20;
    public int spawntime = 5;
    private float sptime = 0;


    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Move>().speed = 10;
        for (int i = 0; i < 100; i ++)
        {
            Debug.Log("Function start");
            while (sptime < spawntime)
            {
                sptime += Time.deltaTime;
                Debug.Log(sptime);
            }
            spawntime = RandomNumber(minSpawntime, maxSpawntime);
            Vector3 position;
            position = new Vector3(RandomNumber(minX, maxX), RandomNumber(minY, maxY), RandomNumber(minZ, maxZ));
            Quaternion rotation = Quaternion.LookRotation(position, Vector3.up);
            Instantiate(spawnee, position, rotation);
            sptime = 0;
            while (sptime < spawntime)
            {
                sptime += Time.deltaTime;
            }
            if (stillKill == true)
            {
                Destroy(spawnee);
            }
            sptime = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }


    public int RandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "PowerUp")
        {
            Destroy(col.gameObject);
            //stillKill = false;
            int randomChoice = RandomNumber(1, 8);
            switch (randomChoice)
            {
                case 1:
                    GetComponent<Move>().speed = 1.5f;
                    break;
                case 2:
                    tank2.GetComponent<Move>().speed = 1.5f;
                    break;
                default:
                    tank1.GetComponent<Move>().speed = 7.5f;
                    sptime = 0;
                    while (sptime < 10)
                    {
                        sptime += Time.deltaTime;
                    }
                    GetComponent<Move>().speed = 5;
                    break;
            }


        }
    }
}
