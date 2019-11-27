using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float m_speed;

    private float m_PlayerHP = 3;

    private Vector3 m_position; //(x,y,z)

    public bool m_CanHeMove = true;
  

    private void Start()
    {
        m_position = transform.position; //m_position = (0,0,4)
    }


    void Update()
    {
        //Si le joueur appui sur le clic gauche de la souris
        if (Input.GetMouseButton(0) && m_CanHeMove == true)
        {
            LocatePosition();

            
        }

        MoveToPosition();

        if (m_position.y > 0)
        {
            m_position.y = 0f;
        }

        if (m_PlayerHP <= 0)
        {

            FindObjectOfType<GameOverTrigger>().m_GameOverMenu.SetActive(true);
        }

    }

    void LocatePosition()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000f) && hit.transform.gameObject.tag == "Ground")
        {
            m_position = hit.point;
        }
    }

    void MoveToPosition()
    {
        transform.LookAt(m_position);
        transform.position = Vector3.MoveTowards(transform.position, m_position, m_speed * Time.deltaTime);
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "EnemyBall")
        {
            m_PlayerHP -= 1;

            Debug.Log(m_PlayerHP);
        }
     
    }

}
