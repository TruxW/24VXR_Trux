using UnityEngine;
using UnityEngine.SceneManagement;  // For scene management
using UnityEngine.UI;              // For button UI components

public class StartScreenManager : MonoBehaviour
{
    // Call this method for the Play button
    public void StartGame()
    {
        // Load the scene named "GameScene" (replace with your actual scene name)
        SceneManager.LoadScene("Vergessen");
    }

    // Call this method for the Options button
    public void OpenOptions()
    {
        // Load the options scene (replace with actual options scene name)
        SceneManager.LoadScene("OptionsScene");
    }

    // Call this method for the Exit button
    public void ExitGame()
    {
        // Quit the game (works only in a built application, not in the editor)
        Debug.Log("Exiting Game...");
        Application.Quit();
    }
}
