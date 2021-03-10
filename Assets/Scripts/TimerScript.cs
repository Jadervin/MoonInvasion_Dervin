using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public string win;
    public Text startText;

    public EnemyMovement[] enemymove;
    public EnemySpawn[] enemyspawn;
    public int scriptSelected = 0;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                startText.text = (timeRemaining).ToString("0");
            }
            else if(timeRemaining < 60 && timeRemaining > 0)
            {
                enemyspawn[scriptSelected].minSpawnSec = enemyspawn[scriptSelected].minSpawnSec / 2;
                enemyspawn[scriptSelected].maxSpawnSec = enemyspawn[scriptSelected].maxSpawnSec / 2;

                enemymove[scriptSelected].Speed = enemymove[scriptSelected].Speed * 2;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
            if (timerIsRunning == false)
            {

                SceneManager.LoadScene(win);
            }
        }
    }
}
