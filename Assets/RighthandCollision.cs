using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RighthandCollision : MonoBehaviour
{
    public Player2Health player2Health;
    public Animator AnimControllerPlayer1;
    public Animator AnimControllerPlayer2;
    public Transform player1;
    public Transform player2;
    public bool punchConnected;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        punchConnected = false;

        if (other.gameObject.tag == "Player2")
        {   

            AnimatorStateInfo stateInfo = AnimControllerPlayer1.GetCurrentAnimatorStateInfo(0);
            //AnimatorClipInfo[] clipInfo = AnimControllerPlayer1.GetCurrentAnimatorClipInfo(0);

            Debug.Log("punchcontacted");
            
            if (stateInfo.IsName("Forward")){
                Debug.Log("HandContacted");
            }       



        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player2")

        {
            AnimatorStateInfo stateInfo = AnimControllerPlayer1.GetCurrentAnimatorStateInfo(0);

            Debug.Log("punchstaying");
            if (stateInfo.IsName("Punch_1_Active") && !punchConnected){
                
                player2Health.TakeDamage(5);
                AnimControllerPlayer2.SetTrigger("HeadHit");

                punchConnected = true;

            } 
            if(stateInfo.IsName("Punch_2_Active") && !punchConnected){
                player2Health.TakeDamage(5);
                AnimControllerPlayer2.SetTrigger("BodyHit");
                
                punchConnected = true;

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            PunchManager();
            Debug.Log("punchgone");
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
