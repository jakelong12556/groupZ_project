using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float MovementSpeed;
    public Animator AnimController;

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    public void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(MovementSpeed, 0, 0);
            //AnimController.Play("Forward");
            AnimController.SetFloat("right", 0.1f);
        }
        else
        {
            AnimController.SetFloat("right", -0.1f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(-MovementSpeed, 0, 0);
            //AnimController.Play("Back");
            AnimController.SetFloat("left", 0.1f);
        }
        else
        {
            AnimController.SetFloat("left", -0.1f);
        }
    }
}
