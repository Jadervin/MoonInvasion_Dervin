using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float speed;
    public float despawnTime;
    public int damage;
    float timeAlive = 0;
    public GameObject gitsEffect;



    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
       
        //(x,y,z )* speed = (speed*x,speed*y,speed*z)
        //(1,0,0)* speed = (speed,0,0)

        timeAlive += Time.deltaTime;

        if(timeAlive>despawnTime)
        {
            Destroy(gameObject);

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Instantiate(gitsEffect, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
