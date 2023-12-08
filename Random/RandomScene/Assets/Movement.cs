using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody cube;
    public float forwardForce = 500;
    public float sideForce = 500;
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            cube.AddForce(0, 0, forwardForce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            cube.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            cube.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            cube.AddForce(0, 0, -forwardForce * Time.deltaTime,ForceMode.VelocityChange);
        }
    }
}
