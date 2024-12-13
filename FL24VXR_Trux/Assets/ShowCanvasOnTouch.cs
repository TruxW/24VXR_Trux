using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShowCanvasOnTouch : MonoBehaviour
{
    // Reference to the Canvas to be shown
    public GameObject canvasToShow;

    // Optional: Add an XR Interactor if you want specific interactions with VR controllers
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the controller (or another object)
        if (other.CompareTag("PlayerHand"))  // Make sure your VR controllers have the "PlayerHand" tag
        {
            // Show the Canvas when the controller (or target object) touches this object
            if (canvasToShow != null)
            {
                canvasToShow.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Optionally hide the canvas when the touch ends (e.g., controller stops touching)
        if (other.CompareTag("PlayerHand"))  // Ensure this tag matches your controller's tag
        {
            if (canvasToShow != null)
            {
                canvasToShow.SetActive(false);
            }
        }
    }
}

