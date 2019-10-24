using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player; //the player

    public float m_PlayerMovementPerSec = 1f;

    private float m_Percentage;

    Vector3 destination; //(0,0,0)


    void Start()
    {
        destination = player.transform.position; //set to destination the player's position
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; //create a raycast

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100) && hit.transform.gameObject.tag == "Ground")
            {
                destination = hit.point;
            }
        }
    }

    void FixedUpdate()
    {
        
        float m_Distance = Vector3.Distance(player.transform.position, destination); //set the distance between the player and is distination
        if (m_Distance > 0)
        {

            float m_MoveDis = Mathf.Clamp(m_PlayerMovementPerSec * Time.deltaTime, 0, m_Distance);

            Vector3 move = (destination - transform.position).normalized * m_MoveDis;
            player.transform.Translate(move);
        }
        
        /*
        m_Percentage = Time.deltaTime * 1f;

        transform.position = Vector3.Lerp(player.transform.position, destination, m_Percentage);
        */
    }

}
