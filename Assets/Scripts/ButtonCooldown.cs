using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCooldown : MonoBehaviour
{
    [SerializeField]
    Button myButton;
    [SerializeField]
    float cooldownDuration = 5;

    void Awake()
    {
        // Get a reference to your button
        myButton = GetComponent<Button>();

        if (myButton != null)
        {
            
            myButton.onClick.AddListener(OnButtonClick);
        }
    }


    private void Start()
    {
        
    }
    // This method is called whenever myButton is pressed
    void OnButtonClick()
    {
        StartCoroutine(Cooldown());
    }

    // Coroutine that will deactivate and reactivate the button 
    IEnumerator Cooldown()
    {
        // Deactivate myButton
        myButton.interactable = false;
        // Wait for cooldown duration
        yield return new WaitForSeconds(cooldownDuration);
        // Reactivate myButton
        myButton.interactable = true;
    }
}
