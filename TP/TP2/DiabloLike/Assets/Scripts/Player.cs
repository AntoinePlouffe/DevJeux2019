using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player; //the player

    public Camera m_Camera;

    private Vector3 m_StartPos;
    private Vector3 m_EndPos;
    public float m_ProgressionPercentage;

    private float m_Distance;

    private Coroutine m_MoveCoroutine;





    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray moveRay = m_Camera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit; //create a raycast
            if (Physics.Raycast(moveRay, out hit, 1000f, LayerMask.GetMask("Ground")))
            {
                m_StartPos = transform.position;
                m_EndPos = hit.point;
                m_Distance = Vector3.Distance(m_StartPos, m_EndPos);
                m_ProgressionPercentage = 0f;

                if (m_MoveCoroutine != null)
                {
                    StopCoroutine("Move");
                }

                m_MoveCoroutine = StartCoroutine("Move");
            }
        }

    }
  
    IEnumerator Move()
    {

        while (m_ProgressionPercentage < 1f)
        {
            m_ProgressionPercentage += 5f * Time.deltaTime / m_Distance;
            transform.position = Vector3.Lerp(m_StartPos, m_EndPos, m_ProgressionPercentage);

            yield return null;
        }
    }

}
