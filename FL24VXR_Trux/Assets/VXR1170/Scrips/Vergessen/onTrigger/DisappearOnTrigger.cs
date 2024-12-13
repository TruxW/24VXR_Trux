using UnityEngine;

public class DisappearOnCollision : MonoBehaviour
{
    public GameObject objectToAppear;   // Reference to the prefab that will appear
    public Transform spawnPoint;        // Location where the new object will appear
    public AudioClip collisionSound;    // Reference to the sound clip to play on collision
    private AudioSource audioSource;    // Reference to the AudioSource component
    public Light lightToChange;         // Reference to the light you want to change the color of
    public Color newLightColor = Color.red;  // The new color to set for the light

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    // This function is called when a collision with another object occurs
    private void OnCollisionEnter(Collision collision)
    {
        // Optionally, check for a specific tag, name, or type of object that collides
        if (collision.gameObject.CompareTag("Player"))
        {
            // Play the collision sound
            if (audioSource != null && collisionSound != null)
            {
                audioSource.PlayOneShot(collisionSound);
            }
            else
            {
                Debug.LogWarning("AudioSource or collision sound is missing.");
            }

            // Destroy the current object
            Destroy(gameObject);

            // Instantiate a new object at the specified position and rotation
            if (objectToAppear != null && spawnPoint != null)
            {
                Instantiate(objectToAppear, spawnPoint.position, spawnPoint.rotation);
            }
            else
            {
                Debug.LogWarning("Prefab or spawn point is not assigned.");
            }

            // Change the light color if a light reference is assigned
            if (lightToChange != null)
            {
                lightToChange.color = newLightColor;
            }
            else
            {
                Debug.LogWarning("Light reference is missing.");
            }
        }
    }
}





