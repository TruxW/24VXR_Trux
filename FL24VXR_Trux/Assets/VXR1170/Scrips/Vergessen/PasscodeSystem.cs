using UnityEngine;
using UnityEngine.UI;

public class PasscodeSystem : MonoBehaviour
{
    public Text codeDisplay; // Text element that shows the input code
    public string correctPasscode = "1234"; // The correct passcode
    private string enteredCode = ""; // The code entered by the player

    // Reference to buttons for number input
    public Button[] numberButtons;
    public Button submitButton;
    public Button clearButton;

    void Start()
    {
        // Set up button listeners
        foreach (Button button in numberButtons)
        {
            button.onClick.AddListener(() => OnNumberButtonClick(button));
        }

        submitButton.onClick.AddListener(SubmitPasscode);
        clearButton.onClick.AddListener(ClearCode);
    }

    // This function is called when a number button is clicked
    void OnNumberButtonClick(Button clickedButton)
    {
        // Append the clicked number to the entered code
        enteredCode += clickedButton.GetComponentInChildren<Text>().text;
        codeDisplay.text = enteredCode;
    }

    // This function is called when the submit button is clicked
    void SubmitPasscode()
    {
        if (enteredCode == correctPasscode)
        {
            codeDisplay.text = "Unlocked!";  // Success message
            codeDisplay.color = Color.green; // Optional: Change text color to green
        }
        else
        {
            codeDisplay.text = "Incorrect Code"; // Failure message
            codeDisplay.color = Color.red;     // Optional: Change text color to red
        }
    }

    // This function is called when the clear button is clicked
    void ClearCode()
    {
        enteredCode = "";
        codeDisplay.text = "";
    }
}

