using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupTrigger : MonoBehaviour
{
    public GameObject uiPopup; // Assign your UI Popup in the inspector

    void Start()
    {
        uiPopup.SetActive(false); // Ensure the popup is not visible at the start
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is your character
        if (other.gameObject.tag == "Character")
        {
            uiPopup.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the object exiting the trigger is your character
        if (other.gameObject.tag == "Character")
        {
            uiPopup.SetActive(false);
        }
    }
}
