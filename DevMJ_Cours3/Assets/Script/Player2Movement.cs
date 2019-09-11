using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{

    Rigidbody rb;
    Vector3 m_Movement;
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        m_Movement = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        m_Movement = transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_Movement.z = m_Movement.z + speed;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            m_Movement.z = m_Movement.z - speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Movement.x = m_Movement.x - speed;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Movement.x = m_Movement.x + speed;
        }

        transform.position = m_Movement;
    }
}
