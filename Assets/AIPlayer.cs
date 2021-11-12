using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : MonoBehaviour
{

    public static AIPlayer instance;
    public Animator AnimController;
    public bool canReceiveInput;
    public bool inputReceived;
    public bool inputReceived2;
    public bool inputReceived3;
    public Vector3 pos;
    public float doubleTap = 0.2f;
    public int buttonCount = 0;

    Dictionary<int, System.Action> moves = new Dictionary<int, System.Action>();
    System.Random random = new System.Random();

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        int num = random.Next(1, 5);
        moves.Add(1, MoveForward);
        moves.Add(2, MoveBackward);
        moves.Add(3, Crouch);
        moves.Add(4, Stand);
        moves.Add(5, Attack1);
        moves.Add(6, Attack2);
        moves.Add(7, Attack3);

        canReceiveInput = true;
        inputReceived = false;
        pos = new Vector3(transform.position.x + 100, transform.position.y, transform.position.z);
    }


    // Update is called once per frame
    void Update()
    {
        int num = random.Next(1, 7);

        switch (num)
        {
            case 1:
                moves[1]();
                break;

            case 2:
                moves[2]();
                break;
            case 3:
                moves[3]();
                break;
            case 4:
                moves[4]();
                break;
            case 5:
                moves[5]();
                break;
            case 6:
                moves[6]();
                break;
            case 7:
                moves[7]();
                break;

            default:
                break;
        }

    }


    public void MoveForward()
    {
        AnimController.SetBool("forward", true);
    }

    public void MoveBackward()
    {
        AnimController.SetBool("forward", false);
    }

    public void Crouch()
    {
        AnimController.SetBool("crouch", true);
    }

    public void Stand()
    {
        AnimController.SetBool("crouch", false);
    }

    public void Attack1()
    {
        if (canReceiveInput)
        {
            inputReceived = true;
            canReceiveInput = false;

        }

    }

    public void Attack2()
    {
        if (canReceiveInput)
        {
            inputReceived2 = true;
            canReceiveInput = false;

        }

    }

    public void Attack3()
    {
        if (canReceiveInput)
        {
            inputReceived3 = true;
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

//public void Move()
//{
//    if (Input.GetKey(KeyCode.J))
//    {
//        AnimController.SetBool("forward", true);
//    }
//    else
//    {
//        AnimController.SetBool("forward", false);
//    }

//    if (Input.GetKey(KeyCode.L))
//    {
//        AnimController.SetBool("backward", true);
//    }
//    else
//    {
//        AnimController.SetBool("backward", false);
//    }
//    if (Input.GetKey(KeyCode.K))
//    {
//        AnimController.SetBool("crouch", true);
//    }
//    else
//    {
//        AnimController.SetBool("crouch", false);
//    }
//}
//public void Attack()
//{
//    if (Input.GetKeyDown(KeyCode.H) && Input.GetKey(KeyCode.K))
//    {
//        if (canReceiveInput)
//        {
//            inputReceived3 = true;
//            canReceiveInput = false;
//        }
//        else
//        {
//            Debug.Log("no sweep");
//            return;
//        }
//    }
//    if (Input.GetKeyDown(KeyCode.H))
//    {
//        if (canReceiveInput)
//        {
//            inputReceived = true;
//            canReceiveInput = false;
//        }
//        else
//        {
//            Debug.Log("no punch");
//            return;
//        }
//    }
//    if (Input.GetKeyDown(KeyCode.Y))
//    {
//        if (canReceiveInput)
//        {
//            inputReceived2 = true;
//            canReceiveInput = false;
//        }
//        else
//        {
//            Debug.Log("no punch2");
//            return;
//        }
//    }

//}
//  public void InputManager()
//{
//   if (!canReceiveInput)
//  {
//     canReceiveInput = true;
//}
//else
//{
//   canReceiveInput = false;
//}

//}
//}