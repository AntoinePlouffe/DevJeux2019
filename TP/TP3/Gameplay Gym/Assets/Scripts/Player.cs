using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody m_Rigidbody;

    public float m_Speed = 0;
    private Vector3 m_Direction;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        ///Player movement with translate
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * m_Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * m_Speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * m_Speed * Time.deltaTime);
        }

        /*OR*/


        ///Player movement without translate
        /*
        m_Direction.x = 0f;
        m_Direction.z = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            m_Direction += transform.forward;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            m_Direction += -transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_Direction += -transform.right;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            m_Direction += transform.right;
        }

        m_Direction.Normalize();
        m_Direction *= m_Speed;

        m_Rigidbody.velocity = m_Direction;
        */

    }
}
