using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBulletScript : MonoBehaviour
{



    public float expiryTime = 0f;
    //public Health healthstat;
    public GameObject Player;
    public string gameover;





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

        
        if (collision.gameObject.tag == "Player")
        {

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            SceneManager.LoadScene(gameover);
        }

    }





}
