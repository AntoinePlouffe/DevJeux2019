using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject m_Door;

    public Vector3 m_StartDoor;
    public Vector3 m_EndDoor;

    public float m_Speed = 0f;
    public float m_Delai = 0f;

    private float m_Percentage;

    private bool PressurePlateOnOff = false;

    //Losqu'il a une collision avec un gameObject
    private void OnTriggerEnter(Collider other)
    {
        //Si le gameObject est Crate
        if (other.gameObject.tag == "Crate" && PressurePlateOnOff == false)
        {
            Debug.Log("Trigger");

            StartCoroutine(DoorOpen()); //Demarre la coroutine DoorOpen

            PressurePlateOnOff = true;
        }

       gameObject.GetComponent<Renderer>().material.color = Color.green; //Change la couleur du gameObject
    }

    //Deplace la porte du point A au point B
    IEnumerator DoorOpen()
    {
        Debug.Log("coroutine start");

        while (m_Door.transform.position != m_EndDoor)
        {
            m_Percentage += Time.deltaTime * 1.5f;

            m_Door.transform.position = Vector3.Lerp(m_StartDoor, m_EndDoor, m_Percentage);

            yield return new WaitForSeconds(.1f);
        }


    }
}
