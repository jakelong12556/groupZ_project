using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{ 
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    public float MovementSpeed;
    public float JumpPower;

    public void Move()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-MovementSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(MovementSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * JumpPower);
        }
    }
}
