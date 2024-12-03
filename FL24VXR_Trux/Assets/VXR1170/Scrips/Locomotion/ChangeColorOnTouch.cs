using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnTouch : MonoBehaviour
{
    public Color newColor = Color.red;

    private Renderer objectRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Renderer component from this object
        objectRenderer = GetComponent<Renderer>();
    }

    // This method is called when another collider enters this object's collider
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a specific object (optional)
        // if (collision.gameObject.CompareTag("YourTag")) { }

        // Change the color of the object's material
        objectRenderer.material.color = newColor;
    }

    // Optionally, if you want to change back to original color when the collision ends:
    private void OnCollisionExit(Collision collision)
    {
        // Reset the color when the collision ends (optional)
        // objectRenderer.material.color = originalColor;
    }
}
