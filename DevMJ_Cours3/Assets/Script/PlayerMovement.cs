using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 2.0f;
    private float speed2 = 0.0f;
    public float turnSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //PlayerMovement
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.right * -speed;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = transform.forward * -speed;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }

        else
        {
            rb.velocity = transform.forward * speed2;
        }

        //PlayerRotation
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        } 
    }
}
