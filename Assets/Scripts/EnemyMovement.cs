using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Range(0, 100)]
    public float Speed;
    //private Vector3 movement;
    //[SerializeField]
    //public GameObject Enemy;

    //public Rigidbody rb;


    public CharacterController controller;
    //Vector3 direction;

    

    //public string youwin;



    public Health health;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 movementVector = transform.forward * Speed * Time.deltaTime;

        controller.Move(movementVector);
        */
        

        transform.position += transform.forward * Speed * Time.deltaTime;


        
    }
    private void OnCollisionEnter(Collision collision)
    {

    }

}
