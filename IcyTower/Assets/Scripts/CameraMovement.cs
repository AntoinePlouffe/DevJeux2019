using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public float m_Speed = 0f;
    private float m_Delai = 0f;
    Vector3 velocity = new Vector3();


    private void Awake()
    {

    }

    public void Update()
    {
         if (m_Delai < 1700)
        {
            transform.position += Vector3.up * m_Speed * Time.deltaTime;
            m_Delai = m_Delai + 1;
        }
        else
        {
            m_Speed = 0f;
        }
    }


}
