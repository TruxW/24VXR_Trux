using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightControlVR : MonoBehaviour
{
    // Reference to the light component (it could be on a different GameObject)
    public Light lightToControl;

    // Reference to the XR Interactable (the object being interacted with in VR)
    private XRGrabInteractable interactable;

    void Start()
    {
        // Check if lightToControl is set in the inspector (optional but good practice)
        if (lightToControl == null)
        {
            Debug.LogWarning("Light not assigned in the inspector. Please assign a Light to control.");
        }

        // Get the XRGrabInteractable component (used for VR interaction)
        interactable = GetComponent<XRGrabInteractable>();

        // Optional: Make sure the light is on by default (if it exists)
        if (lightToControl != null)
        {
            lightToControl.enabled = true;
        }

        // Subscribe to interaction events
        if (interactable != null)
        {
            interactable.onActivate.AddListener(ToggleLight);
        }
    }

    // Called when the object is activated (gripped or clicked in VR)
    private void ToggleLight(XRBaseInteractor interactor)
    {
        if (lightToControl != null)
        {
            lightToControl.enabled = !lightToControl.enabled;  // Toggle the light
        }
    }

    // Optionally, you could handle deactivation as well
    private void OnDestroy()
    {
        if (interactable != null)
        {
            interactable.onActivate.RemoveListener(ToggleLight);
        }
    }
}
