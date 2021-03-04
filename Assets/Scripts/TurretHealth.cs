using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHealth : MonoBehaviour
{

    public int MaxHP;
    [HideInInspector]
    public int currentHP;
    public int NoHP;

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
    
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Alien")
        {

            currentHP = currentHP - 1;
            //Destroy(other.gameObject);

            if (currentHP == NoHP)
            {
                Destroy(this.gameObject);
                Debug.Log("DESTROYED");
            }
        }

        if (collision.gameObject.tag == "Tank")
        {

            //currentHP = currentHP - 1;
            Destroy(this.gameObject);

            
        }
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
