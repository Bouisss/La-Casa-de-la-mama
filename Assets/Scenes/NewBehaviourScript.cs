using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;


    private void Start()

    {
        ResetGame();

    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text))
        {
            messageText.text = "Please enter a valid number (fucking retard).";
            numberInput.text = "";
            return;
        }

        if (int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "VICTORY (GG gros bg)";
            }

            else if (playerNumber > randomNumber)
            {
                messageText.text = "Plus bas";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Plus haut";
            }

            else
            {
                messageText.text = "Please enter a valid number (fucking retard).";

            }
            numberInput.text = "";
        }






    }


    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number: " + randomNumber);
        messageText.text = "Guess the number...";
    }
}
