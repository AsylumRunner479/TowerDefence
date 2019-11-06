using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class WaveManager : MonoBehaviour
{
    public float waveNumber, spawnTimer, enemySpawnCount;
    public static float enemiesKilled;
    public float maxEnemies, enemyCap;
    public GameObject spawnPoint;
    public string waveText;
    public string enemyText;
    public GameObject[] spawnObject;
    public float radius = 1.0f;
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 10.0f;
    public bool canSpawn;
    public GameObject space;

    // Start is called before the first frame update
    
    void Start()
    {
        waveNumber = 0;
        enemiesKilled = 0;
        maxEnemies = 100;
        spawnTimer = 2;
        enemyCap = 100;
        enemySpawnCount = 0;
    }

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!canSpawn)
            canSpawn = true;
            space.SetActive(false);
        }
        if (spawnTimer >= 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        if (spawnTimer < 0 && canSpawn && !PlayerHandler.isDead)
        {
            if (enemySpawnCount< maxEnemies)
            {
                Invoke("AddRandom", 2f);
                spawnTimer = 2;
                canSpawn = true;
            }
            else
            {
                canSpawn = false;
            }
        }
        if (!canSpawn)
        {
            if(enemiesKilled == enemyCap)
            {
                canSpawn = true;
                waveNumber++;
                enemySpawnCount = 0;
                space.SetActive(true);
                
            }
        }
    }
    void EnemyType ()
    {

    }
    // Update is called once per frame
    public GameObject[] Enemy;
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


    void AddRandom()
    {
        int randomIndex = UnityEngine.Random.Range(0, Enemy.Length);
        GameObject objectToCreate = Enemy[randomIndex];
        Instantiate(objectToCreate);

        enemySpawnCount++;

        //DestroyObject;
    }
}