using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RighthandCollision2 : MonoBehaviour
{
    public Player1Health player1Health;
    public Animator AnimControllerPlayer1;
    public Animator AnimControllerPlayer2;
    public Transform player1;
    public Transform player2;
    public bool punchConnected;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        punchConnected = false;
        Debug.Log("punchcontactegsdfgsdfd");


        if (other.gameObject.tag == "Player1")
        {

            AnimatorStateInfo stateInfo = AnimControllerPlayer2.GetCurrentAnimatorStateInfo(0);
            //AnimatorClipInfo[] clipInfo = AnimControllerPlayer1.GetCurrentAnimatorClipInfo(0);

            Debug.Log("asdfad");

            if (stateInfo.IsName("Forward"))
            {
                Debug.Log("HandContacted");
            }



        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player1")

        {
            AnimatorStateInfo stateInfo = AnimControllerPlayer1.GetCurrentAnimatorStateInfo(0);
            AnimatorStateInfo stateInfo2 = AnimControllerPlayer2.GetCurrentAnimatorStateInfo(0);


            if (stateInfo2.IsName("Punch_1_Active") && !punchConnected)
            {

                player1Health.TakeDamage(5);
                AnimControllerPlayer1.SetTrigger("HeadHit");

                punchConnected = true;

            }

            if (stateInfo.IsName("Back") && !punchConnected && !stateInfo2.IsName("Forward"))
            {
                Debug.Log("Blocking");
                AnimControllerPlayer1.SetTrigger("Block");

                punchConnected = true;

            }


            if (stateInfo2.IsName("Punch_2_Active") && !punchConnected)
            {
                player1Health.TakeDamage(5);
                AnimControllerPlayer1.SetTrigger("BodyHit");

                punchConnected = true;

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            PunchManager();
        }
    }

    public void PunchManager()
    {
        if (!punchConnected)
        {
            punchConnected = true;
        }
        else
        {
            punchConnected = false;
        }

    }

}
