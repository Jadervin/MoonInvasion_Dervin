using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Range(0, 100)]
    public float Speed;
    private Vector2 movement = new Vector2(1, 1);
    [SerializeField]
    public GameObject Enemy;
    public Rigidbody rb;
    public CharacterController controller;
    Vector3 direction;

    //public string movementAxis = "Horizontal";
    //public string movementAxis2 = "Vertical";

    //public string youwin;



    public Health health;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        float movZ = direction.z * Speed * Time.deltaTime;
        //float movZ = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        float gravity = Physics.gravity.y * Time.deltaTime;
        

        Vector3 movementVector = new Vector3(0, gravity, movZ);
        


        controller.Move(movementVector);
        //Enemy.transform.forward(axis * Speed * Time.deltaTime, 0, 0));

        
        //float axis = Input.GetAxis(movementAxis);

        

        //float axis2 = Input.GetAxis(movementAxis2);

        //Player.transform.Translate(new Vector3(0,0, axis2 * Speed * Time.deltaTime));
        
    }
    private void OnCollisionEnter(Collision collision)
    {

    }

}
