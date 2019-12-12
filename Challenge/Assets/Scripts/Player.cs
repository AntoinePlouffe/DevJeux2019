using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private Rigidbody m_RigidBody;
    private Renderer m_Renderer;
    public Renderer m_MyNemesisRenderer;
    private Vector3 m_Direction;

    public float m_Speed = 5f;
    

    private void Awake()
    {
        m_RigidBody = GetComponent<Rigidbody>();
        m_Renderer = GetComponent<Renderer>();
    }


    void Update()
    {
        PlayerMovement();
        ColorChange();
    }

    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            m_Direction.x = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            m_Direction.x = 1f;
        }
        else
        {
            m_Direction.x = 0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            m_Direction.z = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            m_Direction.z = -1f;
        }
        else
        {
            m_Direction.z = 0f;
        }

        m_Direction.Normalize();
        m_Direction *= m_Speed;
        m_Direction.y = m_RigidBody.velocity.y;
        m_RigidBody.velocity = m_Direction;
    }

    private void ColorChange()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Renderer.material.color = Random.ColorHSV();
            //m_Renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "MyNemesis")
        {
            m_MyNemesisRenderer.material.color = new Color(Random.value, Random.value, Random.value);

            collision.gameObject.AddComponent<Player>().m_Speed = m_Speed;
        }
    }
}