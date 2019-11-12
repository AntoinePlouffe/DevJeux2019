using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody m_Rigidbody;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Jai toucher quelque chose");
        Destroy(gameObject);
    }
}
