using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    public Health healthToDisplay;
    //public Text healthDisplay;
    public Slider healthbar;


    private void Start()
    {
        healthbar.maxValue = healthToDisplay.MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        //healthDisplay.text = healthToDisplay.currentHP.ToString();

        healthbar.value = healthToDisplay.currentHP;
    }
}
