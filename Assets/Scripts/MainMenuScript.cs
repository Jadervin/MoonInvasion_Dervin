using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public string startSceneName;
    public string Menu;
    public string Credits;

    public void StartPressed()
    {
        SceneManager.LoadScene(startSceneName);
      
    
    
    }
    public void MenuPressed()
    {
        SceneManager.LoadScene(Menu);



    }
    public void CreditsPressed()
    {
        SceneManager.LoadScene(Credits);



    }
    public void CloseGame()
    {
        Application.Quit();


    }

    
    
}
