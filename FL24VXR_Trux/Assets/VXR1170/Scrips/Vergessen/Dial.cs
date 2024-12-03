using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Dial : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float animationDuration;
    private bool isRotating = false;
    private int currentIndex;

    [Header("Events")]
    [SerializeField] private UnityEvent<Dial> onDialRotated;

    private void Start()
    {
        //Setup a random starting index and rotate the renderer accordingly
        currentIndex = Random.Range(0, 10);
        transform.localRotation = Quaternion.Euler(currentIndex * -36, 0, 0); 
    }

    public void Rotate()
    {
        // if the dial is already rotating, escape from this method
        if (isRotating)
            return;

        //otherwide, set the dial as rotating to prevent rotating twice
        isRotating = true;

        // Increase the current dial index / number
        currentIndex++;

        // if the number is greater than 10, its not what we want, reset it
        if (currentIndex >= 10)
            currentIndex = 0;

        // Cancel the previous tween on this gameobject if any, and rotate
        // 360' / 10 number = 36', we rotate 36 degrees around the local right axis
        // After the rotation, call the " RotationCompleteCallback " method
        LeanTween.cancel(gameObject);
        LeanTween.rotateAroundLocal(gameObject, Vector3.right, -36, animationDuration).setOnComplete(RotationCompleteCallBack);
    }

    private void RotationCompleteCallBack()
    {
        // Trigger the "onDialRotated" EVENT TO LET THE COMBINATION LOCK THAT THIS SPECIFIFC DIAL HAS ROTATED
        onDialRotated?.Invoke(this);
    }
    
    public int GetNumber()
    {
        // Return the current number of the dial
        return currentIndex;
    }

    public void Lock()
    {
        // Prevents the dial from rotating
        isRotating = true;
    }

    public void Unlock()
    {
        // Allow the dial to rotate
        isRotating = false;
    }

}
