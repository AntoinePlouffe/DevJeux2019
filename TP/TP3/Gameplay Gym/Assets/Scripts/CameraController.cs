using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform m_Parent;

    void Update()
    {
        float m_MouseX = Input.GetAxis("Mouse X");
        float m_MouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.right, m_MouseY * Time.deltaTime * 1000f);
        m_Parent.Rotate(Vector3.up, m_MouseX * Time.deltaTime * 1000f);
    }
}
