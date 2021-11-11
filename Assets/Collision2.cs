using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision2 : MonoBehaviour
{
    // Class is for player 2 body colider. When being hit, to be processed here.
    public Player2Health player2Health;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //tag Player1 is for body touches, should not do damage
        if (other.gameObject.tag == "Player1")
        {
            //player1Health.TakeDamage(5);
            Debug.Log("Enter");
        }

        // else if (other.gameObject.tag == "Player2")
        // {
        //     player2Health.TakeDamage(5);
        // }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            Debug.Log("stayplayer1");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            Debug.Log("exitplayer1");
        }
    }
}
