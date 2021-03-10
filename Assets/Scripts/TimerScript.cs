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
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        startText.text = (timeRemaining).ToString("0");
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
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
