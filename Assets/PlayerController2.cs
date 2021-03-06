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
    public Vector3 pos;

    public float doubleTap = 0.2f;
    public int buttonCount = 0;


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
        pos = new Vector3(transform.position.x + 100, transform.position.y, transform.position.z);
    }


    // Update is called once per frame
    void Update()
    {
        Attack();
        DoubleTap();
        if (doubleTap < 0.001f)
        {
            Move();
        }
        Translate();
    }

    public void Translate()
    {
        AnimatorStateInfo stateInfo = AnimController.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.IsName("Head Hit"))
        {
            float step = 0.3f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pos, step);
        }

        if (stateInfo.IsName("Block"))
        {
            float step = 0.6f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pos, step);
        }
    }


    public void DoubleTap()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (doubleTap > 0 && buttonCount == 1/*Number of Taps you want Minus One*/)
            {
                //Has double tapped
                AnimController.SetTrigger("DashBack");
            }
            else
            {
                doubleTap = 0.2f;
                buttonCount += 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            if (doubleTap > 0 && buttonCount == 1/*Number of Taps you want Minus One*/)
            {
                //Has double tapped
                AnimController.SetTrigger("DashForward");
            }
            else
            {
                doubleTap = 0.2f;
                buttonCount += 1;
            }
        }

        if (doubleTap > 0)
        {

            doubleTap -= 1.0f * Time.deltaTime;

        }
        else
        {
            buttonCount = 0;
        }
    }

    public void Move()
    {
        if (Input.GetKey(KeyCode.J))
        {
            AnimController.SetBool("forward", true);
        }
        else
        {
            AnimController.SetBool("forward", false);
        }

        if (Input.GetKey(KeyCode.L))
        {
            AnimController.SetBool("backward", true);
        }
        else
        {
            AnimController.SetBool("backward", false);
        }
        if (Input.GetKey(KeyCode.K))
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
        if (Input.GetKeyDown(KeyCode.H) && Input.GetKey(KeyCode.K))
        {
            if (canReceiveInput)
            {
                inputReceived3 = true;
                canReceiveInput = false;
            }
            else
            {
                Debug.Log("no sweep");
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
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
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (canReceiveInput)
            {
                inputReceived2 = true;
                canReceiveInput = false;
            }
            else
            {
                Debug.Log("no punch2");
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



