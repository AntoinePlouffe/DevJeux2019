using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool m_flag = false;

    public GameObject player; //Players

    public Camera m_Camera;

    private Vector3 m_Start;

    private Vector3 m_EndPos;

    private float m_distance = 0f;
    public float m_progression = 0f;

    void Update()
    {
        m_Start = transform.position;  //players position

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit clickHit;
            Ray moveRay = m_Camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(moveRay, out clickHit, 1000f, LayerMask.GetMask("Ground")))
            {
                m_EndPos = clickHit.point;

                m_distance = Vector3.Distance(m_Start, m_EndPos);

                m_progression += Time.deltaTime / m_distance;

                transform.position = Vector3.Lerp(m_Start, m_EndPos, 1 / m_progression);
            }
        }
    }

}
