using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Player1Health player1Health;
    public Player2Health player2Health;

    float currentTime = 0f;
    float startingTime = 10f;
    [SerializeField] Text countdownText;
    [SerializeField] Text messageText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (countdownText != null)
        {

            countdownText.text = currentTime.ToString("0");
            messageText.text = "";
        }

        if (currentTime <= 0)

           

        {
            currentTime = 0;

            if (player1Health.currentHealth > player2Health.currentHealth) 
            {
                messageText.text = "PLAYER 1 WINS!";
            }
            else if (player1Health.currentHealth < player2Health.currentHealth) 
            {
                messageText.text = "PLAYER 2 WINS!";
            }
            else 
            {
                messageText.text = "DRAW!";
            }
 
        }

    }
}