using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesFire : MonoBehaviour
{
    public GameObject m_ObjectToSpawn; //EnemyBall
    private float m_Timer = 0f;

    void FixedUpdate()
    {
        StartCoroutine("EnemyShot"); //Demarre la coroutine EnemyShot
    }

    //Fait apparaitre une balle ennemi a chaque 100f
    IEnumerator EnemyShot()
    {
        if (m_Timer == 100f)
        {
            GameObject ballGO;
            ballGO = GameObject.Instantiate(m_ObjectToSpawn, transform.position, Quaternion.identity);

            EnemyBall ball = ballGO.GetComponent<EnemyBall>();
            ball.Shoot(transform.forward);

            m_Timer = 0f;
        }

        m_Timer += 1f;

        yield return new WaitForSeconds(1f);
    }
}
