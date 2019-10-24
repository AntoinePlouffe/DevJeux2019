using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;

    private NavMeshAgent myAgent;

    public GameObject m_Balle_Prefab; //prefab of the balle

    private float m_MonFloat;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {


        //Player shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ballGO;
            ballGO = GameObject.Instantiate(m_Balle_Prefab, transform.position, Quaternion.identity);
            Debug.Log(ballGO);

            Balle ball = ballGO.GetComponent<Balle>();
            ball.Shoot(transform.right);
        }
    }
}
