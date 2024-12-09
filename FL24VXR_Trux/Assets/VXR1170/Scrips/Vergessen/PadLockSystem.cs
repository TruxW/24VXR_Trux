using UnityEngine;
using UnityEngine.UI;  // Required for working with UI elements

public class PadlockSystem : MonoBehaviour
{
    public InputField inputField1;  // First input field
    public InputField inputField2;  // Second input field
    public InputField inputField3;  // Third input field (if using 3-digit combination)
    public InputField inputField4;
    public Button unlockButton;     // Button to check the combination
    public Text feedbackText;       // Text to display feedback (e.g., "Unlocked" or "Incorrect code")

    // The correct combination for the padlock (e.g., 123)
    private string correctCombination = "123";

    void Start()
    {
        // Add listener to the unlock button to check the combination when pressed
        unlockButton.onClick.AddListener(CheckCombination);

        // Initially, set feedback text to empty
        feedbackText.text = "";
    }

    void CheckCombination()
    {
        // Get the entered combination from the input fields
        string enteredCombination = inputField1.text + inputField2.text + inputField3.text + inputField4;

        // Check if the entered combination matches the correct one
        if (enteredCombination == correctCombination)
        {
            feedbackText.text = "Unlocked!";  // Show success message
            feedbackText.color = Color.green;  // Optional: change text color to green
        }
        else
        {
            feedbackText.text = "Incorrect Code";  // Show failure message
            feedbackText.color = Color.red;      // Optional: change text color to red
        }

        // Optionally clear the input fields after attempting
        ClearInputs();
    }

    void ClearInputs()
    {
        // Clear the input fields after a check
        inputField1.text = "";
        inputField2.text = "";
        inputField3.text = "";
        inputField4.text = "";
    }
}

