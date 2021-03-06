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


        if (other.gameObject.tag == "Enemy Bullet")
        {

            currentHP = currentHP - 1;

            if (currentHP == NoHP)
            {
                SceneManager.LoadScene(gameover);

            }
        }



    }


}
