using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class WaveManager : MonoBehaviour
{
    public float waveNumber, spawnTimer, enemySpawnCount;
    public float frequency, magnitude;
    public float enemiesKilled;
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
    public PlayerHandler player;
    // Start is called before the first frame update
    
    void Start()
    {
        waveNumber = 1;
        enemiesKilled = 5;
        maxEnemies = 10;
        spawnTimer = 10;
        enemyCap = 100;
        enemySpawnCount = 0;
        frequency = 1;
        magnitude = 1;
        canSpawn = false;
    }

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !player.isDead)
        {
            if(!canSpawn)
            canSpawn = true;
            space.SetActive(false);
        }
        if (spawnTimer >= 0)
        {
            spawnTimer -= 10*Time.deltaTime;
        }
        if (spawnTimer < 0 && canSpawn && !player.isDead)
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
                
                waveNumber++;
                frequency++;
                if (frequency == 10)
                {
                    magnitude++;
                    frequency = 0;
                    TankManager.waveNumber++;
                }
                maxEnemies = (frequency) * 10;
                enemySpawnCount = 0;
                space.SetActive(true);
                spawnTimer = 10 - frequency;
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

        GameObject clone = Instantiate(spawnObject[spawnObjectIndex]);
        EnemyHandler enemy = clone.GetComponent<EnemyHandler>();
        enemy.player = player;

        if (enemiesKilled != 0)
        {
            Invoke("SpawnEnemy", UnityEngine.Random.Range(minSpawnTime, maxSpawnTime));
        }
    }


    void AddRandom()
    {
        int randomIndex = UnityEngine.Random.Range(0, Enemy.Length);
        GameObject objectToCreate = Enemy[randomIndex];
        GameObject clone = Instantiate(objectToCreate, spawnPoint.transform.position,Quaternion.identity);
        EnemyHandler enemy = clone.GetComponent<EnemyHandler>();
        enemy.player = player;

        enemySpawnCount++;

        //DestroyObject;
    }
}