﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHealth : MonoBehaviour
{

    public int MaxHP;
    [HideInInspector]
    public int currentHP;
    public int NoHP;
    public float cooldownTime;
    //float coolTimer = 0;
    public ParticleSystem turretExplode;
    public ParticleSystem enemyExplode;

    public AudioSource soundSource;
    public AudioClip destroyed;
    public AudioClip enemyDestroyed;

    public float explosionTimer = 2;


    void Start()
    {

        currentHP = MaxHP;
        StartCoroutine(Wait(explosionTimer));
    }

    /*
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Alien")
        {

            currentHP = currentHP - 1;
            //Destroy(other.gameObject);

            if (currentHP == NoHP)
            {
                Destroy(this.gameObject);
                Debug.Log("DESTROYED");
            }
        }

        if (other.gameObject.tag == "Tank")
        {

            //currentHP = currentHP - 1;
            Destroy(this.gameObject);


        }
    }
    */
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Alien")
        {
            if(this.gameObject.tag=="Shield")
            {
                currentHP = currentHP - 1;

                Destroy(collision.gameObject);
                Instantiate(enemyExplode, transform.position, Quaternion.identity);
                soundSource.PlayOneShot(enemyDestroyed);

                if (currentHP == NoHP)
                {
                    Destroy(this.gameObject);
                    Instantiate(turretExplode, transform.position, Quaternion.identity);
                    soundSource.PlayOneShot(destroyed);


                    Destroy(collision.gameObject);
                    Instantiate(enemyExplode, transform.position, Quaternion.identity);
                    soundSource.PlayOneShot(enemyDestroyed);

                    Debug.Log("DESTROYED");
                }

            }
            currentHP = currentHP - 1;

            if (currentHP == NoHP)
            {
                Destroy(this.gameObject);
                Instantiate(turretExplode, transform.position, Quaternion.identity);
                soundSource.PlayOneShot(destroyed);


                Destroy(collision.gameObject);
                Instantiate(enemyExplode, transform.position, Quaternion.identity);
                soundSource.PlayOneShot(enemyDestroyed);

                Debug.Log("DESTROYED");
            }

        }

        if (collision.gameObject.tag == "Tank")
        {
            Destroy(collision.gameObject);
            Instantiate(enemyExplode, transform.position, Quaternion.identity);
            soundSource.PlayOneShot(enemyDestroyed);
            Destroy(this.gameObject);
            Instantiate(turretExplode, transform.position, Quaternion.identity);
            soundSource.PlayOneShot(destroyed);
            

        }
    }


    IEnumerator Wait(float duration)
    {
        //This is a coroutine
        //Debug.Log("Start Wait() function. The time is: " + Time.time);
        //Debug.Log("Float duration = " + duration);
        yield return new WaitForSeconds(duration);   //Wait

        //Debug.Log("End Wait() function and the time is: " + Time.time);

        Destroy(this.gameObject);
        Instantiate(turretExplode, transform.position, Quaternion.identity);
        soundSource.PlayOneShot(destroyed);

    }
}
