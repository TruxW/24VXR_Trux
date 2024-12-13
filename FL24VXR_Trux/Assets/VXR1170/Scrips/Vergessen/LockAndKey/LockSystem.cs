using UnityEngine;

public class LockSystem : MonoBehaviour
{
    public bool isLocked = true; // Default state is locked
    public GameObject lockedDoor; // Reference to the door or object that is locked
    public GameObject unlockedDoor; // The same object when unlocked

    public void ToggleLock()
    {
        if (isLocked)
        {
            Unlock();
        }
        else
        {
            Lock();
        }
    }

    private void Lock()
    {
        isLocked = true;
        lockedDoor.SetActive(true); // Show locked door (or do any other visual change)
        unlockedDoor.SetActive(false); // Hide unlocked version (if you have two models)
        Debug.Log("The door is locked.");
    }

    private void Unlock()
    {
        isLocked = false;
        lockedDoor.SetActive(false); // Hide locked door
        unlockedDoor.SetActive(true); // Show unlocked version
        Debug.Log("The door is unlocked.");
    }
}

