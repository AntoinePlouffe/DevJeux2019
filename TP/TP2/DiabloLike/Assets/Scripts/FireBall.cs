using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public GameObject m_ObjectToSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ballGO;
            ballGO = GameObject.Instantiate(m_ObjectToSpawn, transform.position, Quaternion.identity);

            Ball ball = ballGO.GetComponent<Ball>();
            ball.Shoot(transform.forward);

        }
    }
}
