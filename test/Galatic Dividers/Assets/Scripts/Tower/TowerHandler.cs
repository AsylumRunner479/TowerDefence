using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TowerHandler : MonoBehaviour
{
    public GameObject target;

    public Animator anim;
    public float dist, targetDist = 500;


    public float fireRate, timeTillNextFire, damage, range;
    public float turnSpeed;


    void Start()
    {


        anim = GetComponent<Animator>();

    }
    void Update()
    {
        if(target == null)
        {
            targetDist = 500;
            foreach (var item in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                dist = Vector3.Distance(item.transform.position, transform.position);
                if (dist <= range)
                {
                    if (dist < targetDist)
                    {
                        target = item;
                        targetDist = dist;
                       
                    }
                }
                else
                {
                    // anim.SetBool("IsShooting", false);
                    timeTillNextFire = 0;
                }
            }
       
        }
        if (target != null)
        {
            //   anim.SetBool("IsShooting", true);
            Vector3 targetDir = target.transform.position - transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, turnSpeed * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDir);
            Shoot();

        }
        timeTillNextFire += Time.deltaTime;
        if (timeTillNextFire >= fireRate)
        {

            timeTillNextFire = 0;
        }
    }

    void Shoot()
    {
        target.GetComponent<EnemyHandler>().Invoke("Fire", 0.75f);

        

    }



}
