using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RighthandCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            Debug.Log("punchcontacted");
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
