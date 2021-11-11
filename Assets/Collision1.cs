using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision1 : MonoBehaviour
{
    public Player1Health player1Health;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {

        // else if (other.gameObject.tag == "Player2")
        // {
        //     player2Health.TakeDamage(5);
        // }
        if (other.gameObject.tag == "Player2")
        {
            Debug.Log("Enter");
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
