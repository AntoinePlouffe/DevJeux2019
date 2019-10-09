using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 m_Start;
    public Vector3 m_End;

    public Rigidbody m_Rigidbody;
    public float m_Speed = 0f;
    private float m_Delai = 0f;
    Vector3 velocity = new Vector3();

    private float m_Percentage;

    private void Awake()
    {
        m_Percentage = 0f;
    }

    public void Update()
    {
        m_Percentage += Time.deltaTime * 0.04f;
        /*
         if (m_Delai < 1700)
        {
            transform.position += Vector3.up * m_Speed * Time.deltaTime;
            m_Delai = m_Delai + 1;
        }
        else
        {
            m_Speed = 0f;
        }
        */
        if (m_Percentage >= 1f)
        {
            m_Percentage = 1f;
        }

        transform.position = Vector3.Lerp(m_Start, m_End, m_Percentage);
    }


}
