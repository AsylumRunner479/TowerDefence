using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public float curHealth;
    NavMeshAgent Agent;
    public float damage;
    public float spawnPoint;
    public float Loot;
    public float attackRange;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1f; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
