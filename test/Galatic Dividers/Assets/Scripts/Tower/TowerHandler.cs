using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TowerHandler : MonoBehaviour
{
    public Transform target;
    
    public Animator anim;
    public float dist;
    
   
    public float fireRate, timeTillNextFire,damage,range;
    public float turnSpeed;
   
  
    void Start()
    {
       // target = GameObject.FindGameObjectsWithTag("Enemy").Transform;
        
        anim = GetComponent<Animator>();
       
    }
    void Update()
    {  
            dist = Vector3.Distance(target.position, transform.position);
            if (dist <= range)
            {
                anim.SetBool("IsShooting", true);
                
                
                Vector3 targetDir = target.position - transform.position;
                Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, turnSpeed * Time.deltaTime, 0.0f);
                transform.rotation = Quaternion.LookRotation(newDir);
                Shoot();
            }

            else
            {
                anim.SetBool("IsShooting", false);
                
               
                timeTillNextFire = 0;
            }
        
    }
    
    void Shoot ()
    {   
            timeTillNextFire += Time.deltaTime;
            if (timeTillNextFire >= fireRate)
            {
                
                Invoke("Fire", 0.75f);
                timeTillNextFire = 0;
            }
        
    }
    

    
}
