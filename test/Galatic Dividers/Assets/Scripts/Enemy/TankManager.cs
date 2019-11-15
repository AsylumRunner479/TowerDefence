using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class TankManager : MonoBehaviour
{
    public static float waveNumber, spawnTimer, enemySpawnCount;
    public float enemiesKilled;
    public float maxEnemies, enemyCap;
    public GameObject spawnPoint;
    public float frequency, magnitude;
    public GameObject[] spawnObject;
    public float radius = 1.0f;
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 10.0f;
    public bool canSpawn;
    void Start()
    {
        waveNumber = 1;
        enemiesKilled = 5;
        maxEnemies = 10;
        spawnTimer = 10;
        enemyCap = 100;
        enemySpawnCount = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!canSpawn)
            canSpawn = true;
            
        }
        if (spawnTimer >= 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        if (spawnTimer < 0 && canSpawn && !PlayerHandler.isDead)
        {
            if (enemySpawnCount < maxEnemies)
            {
                for (int i = 0; i < magnitude; i++)
                {
                    Invoke("AddRandom", 0.5f);
                }

                spawnTimer = 11 - frequency;
                canSpawn = true;
            }
            else
            {
                canSpawn = false;
            }
        }
        if (!canSpawn)
        {
            if(enemySpawnCount >= maxEnemies)
            {


                frequency++;
                if (frequency == 10)
                {
                    magnitude++;
                    frequency = 0;
                    
                }
                maxEnemies = (frequency);
                enemySpawnCount = 0;
                
                spawnTimer = 10 - waveNumber;
            }
        }
    }
    /*/
    void EnemyType ()
    {

    }
    // Update is called once per frame
    
    public Transform spawnPos;
    void SpawnEnemy()
    {
        float spawnRadius = radius;
        int spawnObjectIndex = UnityEngine.Random.Range(0, spawnObject.Length);

        transform.position = UnityEngine.Random.insideUnitSphere * spawnRadius;

        Instantiate(spawnObject[spawnObjectIndex]);

        if (enemiesKilled != 0)
        {
            Invoke("SpawnEnemy", UnityEngine.Random.Range(minSpawnTime, maxSpawnTime));
        }
    }
    /*/
    public GameObject[] Enemy;

    void AddRandom()
    {
        int randomIndex = UnityEngine.Random.Range(0, Enemy.Length);
        GameObject objectToCreate = Enemy[randomIndex];
        Instantiate(objectToCreate, spawnPoint.transform.position, Quaternion.identity);

        enemySpawnCount++;

        //DestroyObject;
    }
}