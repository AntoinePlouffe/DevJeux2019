using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject CellDoor;

    public Vector3 m_Start;
    public Vector3 m_End;

    public float m_Speed = 0f;
    public float m_Delai = 0f;

    private float m_Percentage;

    bool SwitchOnOff = false;

    private void Awake()
    {
        m_Percentage = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && SwitchOnOff == false)
        {
            Debug.Log("Trigger");


            while (CellDoor.transform.position != m_End)
            {
                m_Percentage += Time.deltaTime * 0.02f;

                CellDoor.transform.position = Vector3.Lerp(m_Start, m_End, m_Percentage);
            }

            SwitchOnOff = true;

            
        }
    }
}
