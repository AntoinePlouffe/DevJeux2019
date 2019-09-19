using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    Vector3 velocity = new Vector3();

    public float m_Speed = 0f;
    public float m_Jump = 0f;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //playerMovement
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * m_Speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * m_Speed * Time.deltaTime);
        }


        //PlayerJump
        Debug.DrawRay(transform.position, new Vector3(0f, -0.6f, 0f), Color.red);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, new Vector3(0f, -1f, 0f), out hit, 0.6f) && Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(0f, m_Jump, 0f);
            Debug.Log("j'ai toucher un objet");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "END")
        {
            m_Speed = 0;
            m_Jump = 0;
        }
    }
}
