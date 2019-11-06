using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] Enemy;
    public Transform spawnPos;

    // Start is called before the first frame update
    void Start()
    {
       

        for (int i = 0; i < 30; i++)
        {
            AddRandom();
        }
        
    }
    void AddRandom()
    {
        int randomIndex = Random.Range(0, Enemy.Length);
        GameObject objectToDestroy = Enemy[randomIndex];
        Destroy(objectToDestroy);
        //DestroyObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
