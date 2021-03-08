using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float speed;
    public float despawnTime;
    public int damage;
    float timeAlive = 0;
    public ParticleSystem explosionEffect;

    public AudioSource soundSource;
    public AudioClip kill;


  
    public int tankMaxHP;
    [HideInInspector]
    public int tankcurrentHP;

    public int tankNoHP;
   
    private void Start()
    {
        tankcurrentHP = tankMaxHP;
    }


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
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Alien"))
        {
            Destroy(other.gameObject);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            soundSource.PlayOneShot(kill);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == ("Tank"))
        {

            
            tankcurrentHP -= 1;
            Destroy(this.gameObject);


            if (tankcurrentHP == tankNoHP)
            {
                Destroy(other.gameObject);
                Instantiate(explosionEffect, transform.position, Quaternion.identity);
                soundSource.PlayOneShot(kill);


                Destroy(this.gameObject);
           

                Debug.Log("DESTROYED");
            }
            /*
            Destroy(other.gameObject);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            soundSource.PlayOneShot(kill);
            Destroy(this.gameObject);
            */
        }
    }


    /*
    private void OnCollisionEnter(Collision collision)
    {print("Hit");
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
    */
}
