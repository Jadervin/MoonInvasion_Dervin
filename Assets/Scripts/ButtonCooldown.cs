using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCooldown : MonoBehaviour
{
    [SerializeField]
    Button myButton;
    [SerializeField]
    Image image;
    [SerializeField]
    float cooldownDuration = 5;

    private void Start()
    {
        image.fillAmount = 0;
    }

    void Awake()
    {
        // Get a reference to your button
        myButton = GetComponent<Button>();
        image.fillAmount = 1;
        if (myButton != null)
        {
            
            myButton.onClick.AddListener(OnButtonClick);
        }
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
        image.fillAmount -= 1 / cooldownDuration * Time.deltaTime;
        // Wait for cooldown duration
        yield return new WaitForSeconds(cooldownDuration);
        // Reactivate myButton
        myButton.interactable = true;
    }
}
