using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{


    public int MaxHP;
    [HideInInspector]
    public int currentHP;
    public int NoHP;



    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Alien")
        {

            currentHP = currentHP - 1;
            

            if (currentHP == NoHP)
            {
                Destroy(this.gameObject);
                Debug.Log("DESTROYED");
            }
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
