using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{


    [Range(0, 100)]
    public float Speed;
    private Vector2 movement = new Vector2(1, 1);
    [SerializeField]
    public GameObject Player;
    public Rigidbody rb;
    public CharacterController controller;

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

        float movX = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float movZ = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        float gravity = Physics.gravity.y * Time.deltaTime;


        Vector3 movementVector = new Vector3(movX, gravity, movZ);



        controller.Move(movementVector);


        /*
        float axis = Input.GetAxis(movementAxis);

        Player.transform.Translate(new Vector3(axis * Speed * Time.deltaTime, 0, 0));

        float axis2 = Input.GetAxis(movementAxis2);

        Player.transform.Translate(new Vector3(0,0, axis2 * Speed * Time.deltaTime));
        */
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
