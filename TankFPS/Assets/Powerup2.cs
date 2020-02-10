using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup2 : MonoBehaviour
{

    public GameObject tank1;
    public GameObject tank2;

    public int spawntime = 5;
    private float sptime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
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
