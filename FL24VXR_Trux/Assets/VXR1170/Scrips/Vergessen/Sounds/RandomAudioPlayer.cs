using UnityEngine;
using System.Collections;

public class RandomAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public float minDelay = 1f;
    public float maxDelay = 5f;

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        StartCoroutine(PlayAudioAtRandomIntervals());
    }

    IEnumerator PlayAudioAtRandomIntervals()
    {
        while (true)
        {
            float randomDelay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(randomDelay);

            // Play the audio
            audioSource.Play();
        }
    }
}


