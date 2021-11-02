using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static PlayerController instance;
    public Animator AnimController;

    public bool atkPressed;

    public bool canReceiveInput;
    public bool inputReceived;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //atkPressed = false;
        inputReceived = false;
        canReceiveInput = true;
    }


    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
        // if (Input.GetKey(KeyCode.F) != true || atkPressed == false)
        // {
        //     Attack();
        // }
        // else
        // {
        //     Debug.Log("punch_1_cancelled");
        //     AnimController.SetBool("attack1", false);
        // }
    }


    public void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            AnimController.SetBool("forward", true);
        }
        else
        {
            AnimController.SetBool("forward", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            AnimController.SetBool("backward", true);
        }
        else
        {
            AnimController.SetBool("backward", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            AnimController.SetBool("crouch", true);
        }
        else
        {
            AnimController.SetBool("crouch", false);
        }
    }
    public void Attack()
    {
        // if (Input.GetKey(KeyCode.F))
        // {
        //     if (AnimController.GetCurrentAnimatorStateInfo(0).IsName("Punch_1"))
        //     {
        //         Debug.Log("punch_1_cancelled");
        //         AnimController.SetBool("attack1", false);
        //     }
        //     else
        //     {
        //         AnimController.SetBool("attack1", true);
        //         atkPressed = true;
        //     }
        // }
        // else
        // {
        //     AnimController.SetBool("attack1", false);
        //     atkPressed = false;
        // }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (canReceiveInput)
            {
                inputReceived = true;
                canReceiveInput = false;
            }
            else
            {
                Debug.Log("no punch");
                return;
            }
        }
    }
    public void InputManager()
    {
        if (!canReceiveInput)
        {
            canReceiveInput = true;
        }
        else
        {
            canReceiveInput = false;
        }

    }
}



