using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] footstepSounds;  // Array of footstep sounds to play
    public float stepInterval = 0.5f;   // Time interval between steps
    private float stepTimer;            // Timer to manage step interval

    private CharacterController characterController;
    private bool isGrounded;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Check if the player is grounded and moving
        isGrounded = characterController.isGrounded;

        if (isGrounded && characterController.velocity.magnitude > 0.1f)
        {
            // Accumulate the step timer
            stepTimer += Time.deltaTime;

            if (stepTimer >= stepInterval)
            {
                PlayFootstepSound();
                stepTimer = 0f;
            }
        }
    }

    // Play footstep sound from the array of sounds
    private void PlayFootstepSound()
    {
        if (footstepSounds.Length > 0)
        {
            // Play a random footstep sound from the array
            AudioSource.PlayClipAtPoint(footstepSounds[Random.Range(0, footstepSounds.Length)], transform.position);
        }
    }
}

