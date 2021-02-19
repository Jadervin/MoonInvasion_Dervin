using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingScript : MonoBehaviour
{
    public Transform explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        
    
    /*
        if (other.gameObject.tag=="Bullet")
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            //Destroy(this.gameObject);


        }

        */
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            //Destroy(this.gameObject);


        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
