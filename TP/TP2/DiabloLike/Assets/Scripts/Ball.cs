﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody m_Rigidbody;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //detruit l'objet quand il sort de la map
        if (transform.position.z < -5 || transform.position.z > 100)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -50 || transform.position.x > 50 )
        {
            Destroy(gameObject);
        }
    }

    public void Shoot(Vector3 i_Gun)
    {
        m_Rigidbody.AddForce(i_Gun * 1000f);
    }

    //Detruit l'objet quand il a une collision avec un autre gameObject
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
