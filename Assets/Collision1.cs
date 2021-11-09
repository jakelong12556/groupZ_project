using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision1 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            Debug.Log("Enter");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            Debug.Log("stay");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            Debug.Log("exit");
        }
    }


}
