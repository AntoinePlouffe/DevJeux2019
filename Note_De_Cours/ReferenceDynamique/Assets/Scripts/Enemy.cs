using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player m_Player;
    private int m_HP;

    private void Awake()
    {
        m_HP = 5;
    }

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "balle")
        {
            m_HP--;

            if (m_HP <= 0)
            {
                Destroy(gameObject);
            }
        }
       
    }
}
