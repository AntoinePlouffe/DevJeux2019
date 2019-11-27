using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public GameObject m_Door;

    private Renderer rend;

    public Vector3 m_StartDoor;
    public Vector3 m_EndDoor;

    public float m_Speed = 0f;
    public float m_Delai = 0f;

    private float m_Percentage;

    private void Awake()
    {
        m_Percentage = 0f;
    }

    //Quand il a une collision
    private void OnTriggerEnter(Collider other)
    {
        //Quand il a une collision avec le joueur
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Trigger");
            
            StartCoroutine(DoorOpen());

            rend = GetComponent<Renderer>();
            rend.enabled = false;

        }
    }

    //Ouverture de la porte
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
