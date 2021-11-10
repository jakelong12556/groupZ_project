using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float margin;
    private float z0;
    private float zCam;
    private float wScene;

    private Transform f1;

    private Transform f2;

    private Vector3 start;

    private float xL;

    private float xR;

    public void CalcScreen(Transform p1, Transform p2)
    {
        // Calculates the xL and xR screen coordinates 
        if (p1.position.x < p2.position.x)
        {
            xL = p1.position.x - margin;
            xR = p2.position.x + margin;
        }
        else
        {
            xL = p2.position.x - margin;
            xR = p1.position.x + margin;
        }
    }

    void Start()
    {
        margin = 1.5f;
        z0 = 0;
        start = transform.position;

        // find references to the fighters
        f1 = GameObject.Find("Player1").transform;
        f2 = GameObject.Find("Player2").transform;

        // initializes scene size and camera distance
        CalcScreen(f1, f2);
        wScene = xR - xL;

        zCam = transform.position.z - z0;
    }

    void Update()
    {
        f1 = GameObject.Find("ybot").transform;
        f2 = GameObject.Find("xbot").transform;

        CalcScreen(f1, f2);
        float width = xR - xL;

        if (width > wScene)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, (zCam * width / wScene + z0));

        }
        transform.position = new Vector3(((xR + xL) / 2), transform.position.y, transform.position.z);

    }





}
