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
    public ParticleSystem turretExplode;
    public AudioSource soundSource;
    public AudioClip kill;

    public TankHealth tankHP;
  
    //public int tankMaxHP;
    //[HideInInspector]
    //public int tankcurrentHP;

    //public int tankNoHP;
   
    private void Start()
    {
        //tankcurrentHP = tankMaxHP;
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
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }

        /*
            tankHP.tankcurrentHP -= 1;
            Destroy(this.gameObject);


            if (tankHP.tankcurrentHP == tankHP.tankNoHP)
            {
                Destroy(other.gameObject);
                Instantiate(turretExplode, transform.position, Quaternion.identity);
                soundSource.PlayOneShot(kill);


                Destroy(this.gameObject);
           

                Debug.Log("DESTROYED");
            }
            
            Destroy(other.gameObject);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            soundSource.PlayOneShot(kill);
            Destroy(this.gameObject);
            
        }
          */
        if (other.gameObject.tag == ("Turret"))
        {
            if (this.gameObject.tag == "Enemy Bullet")
            {
                Destroy(other.gameObject);
                Instantiate(turretExplode, transform.position, Quaternion.identity);
                soundSource.PlayOneShot(kill);
                Destroy(this.gameObject);
            }
        }

    }
    
   
    
    private void OnCollisionEnter(Collision collision)
    {
        
        

        if (collision.gameObject.tag == ("Tank"))
        {
            
            print("Hit");
            tankHP.tankcurrentHP -= 1;
            Destroy(this.gameObject);


            if (tankHP.tankcurrentHP == tankHP.tankNoHP)
            {
                Destroy(collision.gameObject);
                Instantiate(explosionEffect, transform.position, Quaternion.identity);
                soundSource.PlayOneShot(kill);


                Destroy(this.gameObject);


                Debug.Log("DESTROYED");
            }
        }

    }
    
}
