using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinSystem : MonoBehaviour
{
    public Player1Health player1Health;
    public Player2Health player2Health;
   

    public Image Player1Round1;
    public Image Player1Round2;
    public Image Player1Round3;

    public Image Player2Round1;
    public Image Player2Round2;
    public Image Player2Round3;

    private bool player1Win1 = false;
    private bool player1Win2 = false;
    private bool player1Win3 = false;

    private bool player2Win1 = false;
    private bool player2Win2 = false;
    private bool player2Win3 = false;


    // Start is called before the first frame update
    void Start()
    {
        Player1Round1.GetComponent<Image>().color = new Color32(60, 60, 60, 255);
        Player1Round2.GetComponent<Image>().color = new Color32(60, 60, 60, 255);
        Player1Round3.GetComponent<Image>().color = new Color32(60, 60, 60, 255);

        Player2Round1.GetComponent<Image>().color = new Color32(60, 60, 60, 255);
        Player2Round2.GetComponent<Image>().color = new Color32(60, 60, 60, 255);
        Player2Round3.GetComponent<Image>().color = new Color32(60, 60, 60, 255);

       // Round1 round1 = gameObject.GetComponentInChildren(typeof(Round1)) as Round1;
        //round1.GetComponent<Image>().color = new Color32(255, 255, 255, 255); //r, g, b, a  
    }

    // Update is called once per frame
    void Update()
    {
       if (player1Health.currentHealth == 0)
        {

            player2Win1 = true;
            changeColorRed(Player1Round1);
            changeColorGreen(Player2Round1);
            //resetHealth(player1Health);
            //resetHealth(player2Health);


            // add red for player 1
            // add green for player 2  
            // reset health
            // advance round 2

        }

       if (player2Health.currentHealth == 0)
       {
            player1Win1 = true;
            changeColorRed(Player2Round1);
            changeColorGreen(Player1Round1);
            resetHealthPlayer1(player1Health);
            resetHealthPlayer2(player2Health);
          //  resetHealth(player1Health);
            //resetHealth(player2Health);


            // add red for player 2
            // add green for player 1
            // reset health
            // advance round 2
        }
    }

    void changeColorRed(Image indicator)
    {
        indicator.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
    }

    void changeColorGreen(Image indicator)
    {
        indicator.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
    }

    void resetHealthPlayer1(Player1Health health)
    {
        health.currentHealth = health.maxHealth;
    }

    void resetHealthPlayer2(Player2Health health)
    {
        health.currentHealth = health.maxHealth;
    }
   // {
     //   Object.currentHealth = Object.maxHealth;
   // }
}
    

