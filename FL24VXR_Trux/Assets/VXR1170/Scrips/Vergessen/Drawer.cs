using UnityEngine;

public class Drawer : MonoBehaviour
{
    public bool isLocked = true; // Initially locked
    public string correctPasscode = "1234"; // Set your desired passcode here

    private void OnMouseDown()
    {
        if (isLocked)
        {
            // Open the passcode UI if the drawer is locked
            OpenPasscodeUI();
        }
        else
        {
            // Open the drawer
            OpenDrawer();
        }
    }

    private void OpenPasscodeUI()
    {
        // Trigger the passcode input UI to appear
        Debug.Log("Drawer is locked! Please enter the passcode.");
        // Show the UI for the passcode input here (you can use Unity UI elements for this)
    }

    private void OpenDrawer()
    {
        // Handle opening the drawer when it's unlocked
        Debug.Log("Opening the drawer...");
        // Add your drawer opening animation or logic here
    }

    public void TryUnlock(string enteredPasscode)
    {
        if (enteredPasscode == correctPasscode)
        {
            isLocked = false;
            Debug.Log("Passcode correct! Drawer unlocked.");
        }
        else
        {
            Debug.Log("Incorrect passcode! Try again.");
        }
    }
}

