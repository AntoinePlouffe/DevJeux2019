using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    Vector3 velocity = new Vector3();

    public float m_Jump = 0f;
    public float m_Speed = 0f;
    public float m_TurnSpeed = 0f;
    private bool m_CanJump;
    // Start is called before the first frame update
    void Start()
    {
        /*m_Rigidbody.useGravity = false;
        m_Rigidbody.isKinematic = true;*/
        m_CanJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement
        velocity = m_Rigidbody.velocity;

        if (Input.GetKey(KeyCode.W))
        {
            velocity.z = m_Speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity.z = -m_Speed;
        }
        else
        {
            velocity.z = 0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = m_Speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -m_Speed;
        }
        else
        {
            velocity.x = 0f;
        }

        //player jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (m_CanJump)
            {
                m_Rigidbody.AddForce(0f, m_Jump, 0f);
                m_CanJump = false;
            }
        }
    }

    private void FixedUpdate()
    {
       /* velocity = m_Rigidbody.velocity;
        velocity.x = 1f;*/

        m_Rigidbody.velocity = velocity;

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_CanJump = true;
        Debug.Log("J'ai touché au sol");
    }
}
