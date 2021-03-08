using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHealth : MonoBehaviour
{

    public int MaxHP;
    [HideInInspector]
    public int currentHP;
    public int NoHP;
    public float cooldownTime;
    float coolTimer = 0;



    void Start()
    {

        currentHP = MaxHP;

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
            currentHP = currentHP - 1;

            if (currentHP == NoHP)
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
                Debug.Log("DESTROYED");
            }


            /*
            if (coolTimer > 0)
            {
                coolTimer -= Time.deltaTime;
            }


            else if (coolTimer <= 0)
            {
                currentHP = currentHP - 1;

                if (currentHP == NoHP)
                {
                    Destroy(this.gameObject);
                    Debug.Log("DESTROYED");
                }

                coolTimer = cooldownTime;


            }
            
            
            */
            //Destroy(other.gameObject);
        }

        if (collision.gameObject.tag == "Tank")
        {
            if (coolTimer > 0)
            {
                coolTimer -= Time.deltaTime;
            }


            else if (coolTimer <= 0)
            {
                Destroy(this.gameObject);
                coolTimer = cooldownTime;
            }
            //currentHP = currentHP - 1;
            

            
        }
    }
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    
}
