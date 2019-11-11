using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float m_speed; 
    private Vector3 m_position; //(x,y,z)
    private bool ismoving; //true or false
  

    private void Start()
    {
        m_position = transform.position; //m_position = (0,0,4)
        ismoving = false;
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            LocatePosition();

            
        }

        MoveToPosition();

        if (m_position.y > 0)
        {
            m_position.y = 0f;
        }

    }

    void LocatePosition()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000f) && hit.transform.gameObject.tag == "Ground")
        {
            m_position = hit.point;
        }
        ismoving = true;
    }

    void MoveToPosition()
    {
        transform.LookAt(m_position);
        transform.position = Vector3.MoveTowards(transform.position, m_position, m_speed * Time.deltaTime);

        if (transform.position == m_position)
        {
            ismoving = false;
        }
        
    }

}
