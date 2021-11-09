using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    public static PlayerController2 instance;
    public Animator AnimController;

    public bool atkPressed;

    public bool canReceiveInput;
    public bool inputReceived;
    public bool inputReceived2;
    public bool inputReceived3;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //atkPressed = false;
        canReceiveInput = true;
        inputReceived = false;
        inputReceived2 = false;
        inputReceived3 = false;
    }


    // Update is called once per frame
    void Update()
    {
        Attack();
        //Move();
    }


    public void Move()
    {
            AnimController.SetBool("forward", true);
    }
    public void Attack()
    {
            if (canReceiveInput)
            {
                inputReceived = true;
                canReceiveInput = false;
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



