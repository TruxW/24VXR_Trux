using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRInteraction : MonoBehaviour
{
    public GameObject canvas;  // The Canvas to show when interacting
    private XRBaseInteractor interactor;  // The VR controller or hand interacting with the object

    private void OnEnable()
    {
        // Ensure the interactor is set up (like VR controllers or hands)
        interactor = GetComponent<XRBaseInteractor>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player/controller is interacting with the object
        if (other.CompareTag("Player") || other.CompareTag("XR Controller"))
        {
            // Display the canvas when the user interacts with the object
            ShowCanvas();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Optionally hide the canvas when the player/controller exits the interaction range
        if (other.CompareTag("Player") || other.CompareTag("XR Controller"))
        {
            HideCanvas();
        }
    }

    // Method to show the Canvas
    private void ShowCanvas()
    {
        if (canvas != null)
        {
            canvas.SetActive(true);
        }
    }

    // Method to hide the Canvas
    private void HideCanvas()
    {
        if (canvas != null)
        {
            canvas.SetActive(false);
        }
    }
}
