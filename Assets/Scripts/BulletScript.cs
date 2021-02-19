using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletScript : MonoBehaviour
{
    public GameObject Player;
    //public Health healthstat;
    public float expiryTime = 0f;
    public string YouWin;
    public Transform explosionEffect;



    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, expiryTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
            if (collision.gameObject.tag == "Enemy")
            {

                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                Debug.Log("DESTROYED");
            }


        if (collision.gameObject.tag == "Boss")
        {

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Debug.Log("DESTROYED");
            SceneManager.LoadScene(YouWin);
        }
    }
    
    

   








}
