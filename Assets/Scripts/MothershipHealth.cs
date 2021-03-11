using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MothershipHealth : MonoBehaviour
{
    public int MaxHP;
    [HideInInspector]
    public int currentHP;
    public int NoHP;

    public string gameover;

    public ParticleSystem mothershipExplosion;
    public ParticleSystem enemyExplode;

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
        MeshRenderer MeshComponent = gameObject.GetComponent<MeshRenderer>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Alien")
        {

            currentHP -= 1;
            Destroy(other.gameObject);
            Instantiate(enemyExplode, transform.position, Quaternion.identity);

            if (currentHP <= NoHP)
            {

                gameObject.GetComponent <Renderer> ().enabled = false;
                Instantiate(mothershipExplosion, transform.position, Quaternion.identity);

                StartCoroutine(Wait(explosionTimer));

                Debug.Log("DESTROYED");
            }
        }

        if (other.gameObject.tag == "Tank")
        {

            currentHP -= 3;
            Destroy(other.gameObject);
            Instantiate(enemyExplode, transform.position, Quaternion.identity);

            if (currentHP <= NoHP)
            {
                //Destroy(this.gameObject);
                
                gameObject.GetComponent<Renderer>().enabled = false;
                Instantiate(mothershipExplosion, transform.position, Quaternion.identity);
                mothershipExplosion.Play();
                StartCoroutine(Wait(explosionTimer));
            }
        }
    }


    IEnumerator Wait(float duration)
    {
        //This is a coroutine
        //Debug.Log("Start Wait() function. The time is: " + Time.time);
        //Debug.Log("Float duration = " + duration);
        yield return new WaitForSeconds(duration);   //Wait

        //Debug.Log("End Wait() function and the time is: " + Time.time);

        SceneManager.LoadScene(gameover);
        
        
    }


}
