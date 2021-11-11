using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision1 : MonoBehaviour
{
    public Player1Health player1Health;
    public Player2Health player2Health;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            player1Health.TakeDamage(5);
            //Debug.Log("Enter");
        }

        else if (other.gameObject.tag == "Player2")
        {
            player2Health.TakeDamage(5);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            //Debug.Log("stay");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            //Debug.Log("exit");
        }
    }


}
