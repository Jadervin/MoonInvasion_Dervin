using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MothershipHealth : MonoBehaviour
{
    public int MaxHP;
    [HideInInspector]
    public int currentHP;
    public string gameover;
    public int NoHP;
    public ParticleSystem mothershipExplosion;
    public float explosionTimer = 2;

    //public PlayerMovement playerMove;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Alien")
        {

            currentHP -= 1;
            //Destroy(other.gameObject);

            if (currentHP == NoHP)
            {   
                //explosionTimer -= Time.deltaTime;
                Destroy(this.gameObject);
                Instantiate(mothershipExplosion, transform.position, Quaternion.identity);

                SceneManager.LoadScene(gameover);

                /*
                if (explosionTimer < 0)
                {
                    SceneManager.LoadScene(gameover);
                }
                */
                Debug.Log("DESTROYED");
            }
        }

        if (other.gameObject.tag == "Tank")
        {

            currentHP -= 3;


            if (currentHP == NoHP)
            {
                Destroy(this.gameObject);
                mothershipExplosion.Play();
                SceneManager.LoadScene(gameover);
                Debug.Log("DESTROYED");
            }
        }
    }





}
