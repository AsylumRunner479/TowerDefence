using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyHandler : MonoBehaviour
{
    public static float score;
    public static float highScore;
    public float moveSpeed;
    public float curHealth;
    NavMeshAgent Agent;
    public float damage;
    public Transform spawnPoint;
    public float Loot;
    public float attackRange;
    //desiginates who the player is
    public Transform target;
    public WaveManager wave;
    public NavMeshAgent agent;
    //public Animator anim;
    //gives distances for how far away the player will be when they switch behaviour
    public float dist;
    public GameObject self;
    //public GameObject projectilePrefab;
    //public Transform launchPoint;
    //public float fireRate, timeTillNextFire;
    public float turnSpeed;
    //public float angle;
    //public EnemyAI myAI;
    public Animator anim;
    public Shop shop;
    //public float curHealth, maxHealth;
    void Start()
    {
        XMIManager.ReadData();
        //sets the conditions at the start
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = self.GetComponent<NavMeshAgent>();
        //myAI = self.GetComponent<EnemyAI>();
        anim = self.GetComponent<Animator>();
        spawnPoint = GameObject.FindGameObjectWithTag("Spawn").transform;
        agent.speed = moveSpeed;
    }

    void Update()
    {
        if (score > highScore)
        {
            highScore = score;
        }
        //kills the enemy when they lose all their health
        if (curHealth <= 0)
        {
            Shop.money += Loot;
            AddScore(Loot);
            Destroy(self);
            // anim.SetTrigger("Die");
            

        }
        //moves the enemy when the player is alive
        if (PlayerHandler.isDead == false)
        {
            dist = Vector3.Distance(target.position, transform.position);

            if (curHealth == 0)
            {
                Destroy(self);
                
                return;
            }
            //attacks the player if they get too close
            else if (dist <= attackRange)
            {
                PlayerHandler.curHealth -= 10f;
                agent.destination = transform.position;
                Debug.Log("Attack");
             //   anim.SetTrigger("Bite Attack");
                Destroy(self);
                
            }
            //follows the player when they see him
            else
            {
                agent.destination = target.position;
            
            }
           
               
            
            

           
        }
    }
    public void AddScore(float scoretoAdd)
   {
       // Increase Score Value by incoming score
       score += scoretoAdd;
      
   }
   
    public void Fire()
    {
        curHealth -= damage;


    }
   
}
