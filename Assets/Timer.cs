using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Player1Health player1Health;
    public Player2Health player2Health;

    float currentTime = 0f;
    float startingTime = 60f;
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
        }

        if (currentTime >= 55 && currentTime <= 60)
        {
            messageText.text = "A: move left \n S: crouch \n D: move right \n F: attack \n FF: combo attack";
        }
        else messageText.text = "";



        if (player1Health.currentHealth == 0)
        {
            messageText.text = "KO! \n PLAYER 2 WINS!";
        }

        else if (player2Health.currentHealth == 0)
        {
            messageText.text = "KO! \n PLAYER 1 WINS!";
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