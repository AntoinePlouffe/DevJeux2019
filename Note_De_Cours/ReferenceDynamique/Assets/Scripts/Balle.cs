using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour
{
    //public Transform m_PlayerTransform;

    private Rigidbody m_MonRigidBody;

    private Vector3 monVector3;

    private void Awake()
    {
       // monVector3 = new Vector3(0f, 5f, 1f);

        m_MonRigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }

    public void Shoot(Vector3 i_PlayerForward)
    {
        m_MonRigidBody.AddForce(i_PlayerForward * 500f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            Debug.Log("j'ai trigger");
            Destroy(gameObject);
        }
       
    }
}
