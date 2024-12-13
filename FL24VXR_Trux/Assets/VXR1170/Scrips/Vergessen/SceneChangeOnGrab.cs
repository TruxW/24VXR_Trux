using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class SceneChangeOnGrab : MonoBehaviour
{
    // Reference to the XRGrabInteractable component
    private XRGrabInteractable grabInteractable;

    // The name of the scene you want to load
    public string sceneToLoad = "NextSceneName"; // Replace with the name of your scene

    void Awake()
    {
        // Get the XRGrabInteractable component attached to this object
        grabInteractable = GetComponent<XRGrabInteractable>();

        if (grabInteractable != null)
        {
            // Register the grab event listener
            grabInteractable.onSelectEntered.AddListener(OnGrabbed);
        }
        else
        {
            Debug.LogError("XRGrabInteractable component not found on the object.");
        }
    }

    // Event handler that is called when the object is grabbed
    private void OnGrabbed(XRBaseInteractor interactor)
    {
        // Load the new scene when the object is grabbed
        Debug.Log("Object grabbed. Changing scene...");
        SceneManager.LoadScene(sceneToLoad);
    }

    // Clean up when the object is released
    private void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(OnGrabbed);
        }
    }
}



