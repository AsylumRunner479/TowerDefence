using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TowerHandler : MonoBehaviour
{
    public GameObject target;

    public Animator anim;
    public float dist, targetDist = 500;
    public GameObject arclines;
    public GameObject self;
    public float fireRate, timeTillNextFire, damage, range;
    public float turnSpeed;
    // set floats for the values in the code

    void Start()
    {


        anim = GetComponent<Animator>();

    }
    void Update()
    {
        //when there isn't a target get an object with the tag Enemy
        if(target == null)
        {
            targetDist = 500;
            foreach (var item in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                dist = Vector3.Distance(item.transform.position, transform.position);
                if (dist <= range )
                {
                    if (dist < targetDist )
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
        //make the rotation restricted based on target position
        if (target != null && timeTillNextFire <= 0)
        {
            //if there is a taget rotate then shoot at it
            //if (((target.transform.position.x > self.transform.position.x && target.transform.position.y > self.transform.position.y) || (target.transform.position.x < self.transform.position.x && target.transform.position.y < self.transform.position.y)))
            //{
                //   anim.SetBool("IsShooting", true);
                Vector3 targetDir = target.transform.position - transform.position;
                Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, turnSpeed * Time.deltaTime, 0.0f);
                transform.rotation = Quaternion.LookRotation(newDir);
                Shoot();
            //}
           //else
            //{
                //target = null;
            //}

        }
        timeTillNextFire += Time.deltaTime;
        if (timeTillNextFire >= fireRate)
        {

            timeTillNextFire = 0;
        }
    }

    void Shoot()
    {
        //shoot activates function to damage enemy
        target.GetComponent<EnemyHandler>().Invoke("Fire", 0.75f);

        

    }



}
