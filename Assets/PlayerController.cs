using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public float MovementSpeed;

    public void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(MovementSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-MovementSpeed, 0, 0);
        }
    }
}
