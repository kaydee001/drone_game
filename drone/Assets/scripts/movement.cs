using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float upForce;
    public float forSpeed = 50.0f;
    public float tiltForward = 0.0f;
    public float tiltVelFor;
    public float yRot;
    public float currentY;
    public float rotAmt = 2.5f;
    public float rotVel;
    public static bool isMovingForward;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        isMovingForward = false;
    }

    void FixedUpdate()
    {
        moveUp();
        moveForward();
        rot();
        rb.AddRelativeForce(Vector3.up * upForce);
        rb.rotation = Quaternion.Euler(new Vector3(tiltForward, currentY, rb.rotation.z));
    }    
    void moveUp()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            upForce = 125;
        }
        else if (Input.GetKey(KeyCode.X))
        {
            upForce = -50;
        }
        else if (!Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.X))
        {
            upForce = 9.8f;
        }
    }
    void moveForward()
    {
        if(Input.GetAxis("Vertical")!= 0)
        {
            rb.AddRelativeForce(Vector3.forward * Input.GetAxis("Vertical") * forSpeed);
            tiltForward = Mathf.SmoothDamp(tiltForward, 5 * Input.GetAxis("Vertical"), ref tiltVelFor, 0.01f);
            isMovingForward = true;
        }
        else
        {
            isMovingForward = false;
        }
    }
    void rot()
    {
        if (Input.GetKey(KeyCode.A))
        {
            yRot -= rotAmt;
        }
        if (Input.GetKey(KeyCode.D))
        {
            yRot += rotAmt;
        }
        currentY = Mathf.SmoothDamp(currentY, yRot, ref rotVel, 0.25f);
    }
}