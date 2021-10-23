using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObostacles : MonoBehaviour
{
    public GameObject obstacle;// poin the obstacles
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn; // detec.>how much time taken to the next obstacle appare

    private float spawnTime;
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime) { 
            Spawn();
         spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);// for random position but in max and min X
        float randomY = Random.Range(minY, maxY);// for random position but in max and min Y
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);// 0 for z axis
    }
}
