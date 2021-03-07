using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject[] projectiles;
    //public ParticleSystem MuzzleFlash;
    public int projectileSelected = 0;
    public GameObject muzzle;
    public float cooldownTime;
    float coolTimer = 0;

    public AudioSource soundSource;
    public AudioClip shot;


    private void Update()
    {

        //ChangeWeapons();
        if(coolTimer>0)
        {
            coolTimer -= Time.deltaTime;
        }


        else if (coolTimer <= 0)
        {
            Shoot();
            coolTimer = cooldownTime;
        }

    }



    /*
    void ChangeWeapons()
    {
        float dir = Input.GetAxis("Mouse ScrollWheel");

        if (dir > 0)
        {
            projectileSelected = (projectileSelected + 1) % projectiles.Length;


        }
        else if (dir < 0)
        {
            if (projectileSelected == 0)
            {
                projectileSelected = projectiles.Length - 1;
            }
            else
            {
                projectileSelected = projectileSelected - 1;
            }

        }

    }
    */


    void Shoot()
    {
        GameObject temp;
        //MuzzleFlash.Play();
        temp = Instantiate(projectiles[projectileSelected], muzzle.transform.position, 
           muzzle.transform.rotation);
        soundSource.PlayOneShot(shot);

    }
}
