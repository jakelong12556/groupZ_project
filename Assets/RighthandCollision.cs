using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RighthandCollision : MonoBehaviour
{
    //public Player2Health player2Health;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {   

            Debug.Log("punchcontacted");
           // player2Health.TakeDamage(5);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player2")

        {
            Debug.Log("punchstaying");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            Debug.Log("punchgone");
        }
    }

}
