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

        if (timeAlive > despawnTime)
        {
            Destroy(gameObject);

        }


    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Alien"))
        {
            Destroy(other.gameObject);
            Instantiate(gitsEffect, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }

        if (other.gameObject.tag == ("Tank"))
        {
            Destroy(other.gameObject);
            Instantiate(gitsEffect, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Alien"))
        {
            Destroy(collision.gameObject);
            Instantiate(gitsEffect, transform.position, Quaternion.identity);

            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == ("Tank"))
        {
            Destroy(collision.gameObject);
            Instantiate(gitsEffect, transform.position, Quaternion.identity);

            Destroy(this.gameObject);
        }

    }
    
}
