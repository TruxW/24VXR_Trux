using UnityEngine;

public class AudioMuteOnMovement : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to your AudioSource
    public float movementThreshold = 0.1f; // Speed threshold to detect movement
    private Rigidbody rb;  // Rigidbody reference to check movement

    void Start()
    {
        // Get the Rigidbody component if not manually assigned
        rb = GetComponent<Rigidbody>();
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>(); // If AudioSource is not assigned in inspector
    }

    void Update()
    {
        // Check if the object is moving
        if (rb.velocity.magnitude > movementThreshold)
        {
            if (!audioSource.isPlaying)
                audioSource.Play(); // Start or unmute the audio
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Pause(); // Mute the audio
        }
    }
}

