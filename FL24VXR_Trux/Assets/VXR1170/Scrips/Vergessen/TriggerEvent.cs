using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    // This will be called when the collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other collider has a specific tag or name
        if (other.CompareTag("Player"))
        {
            // Trigger an event or action here
            Debug.Log("Player has entered the trigger area!");

            // For example: call a method, activate a GameObject, etc.
            // Activate some special event:
            TriggerSpecialEvent();
        }
    }

    private void TriggerSpecialEvent()
    {
        // Example of an event that could be triggered
        Debug.Log("Special event triggered!");
    }
}

