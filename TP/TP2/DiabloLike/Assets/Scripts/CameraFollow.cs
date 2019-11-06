using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; //Player

    public Player m_Player;
    public Boundaries m_Boundaries;


    void Update()
    {

        Vector3 newPos = m_Player.transform.position;

        newPos.x = Mathf.Clamp(newPos.x, m_Boundaries.m_Left.position.x, m_Boundaries.m_Right.position.x);
        newPos.z = Mathf.Clamp(newPos.z, m_Boundaries.m_Back.position.z, m_Boundaries.m_Front.position.z);

        transform.position = newPos;
    }
}
