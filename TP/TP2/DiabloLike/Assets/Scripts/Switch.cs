using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public GameObject CellDoor;

    public Vector3 m_StartCellDoor;
    public Vector3 m_EndCellDoor;

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

            StartCoroutine(DoorOpen());

            SwitchOnOff = true;
        }
    }

    IEnumerator DoorOpen()
    {
        Debug.Log("coroutine start");

        while (CellDoor.transform.position != m_EndCellDoor)
        {
            m_Percentage += Time.deltaTime * 1.5f;

            CellDoor.transform.position = Vector3.Lerp(m_StartCellDoor, m_EndCellDoor, m_Percentage);

            yield return new WaitForSeconds(.1f);
        }

       
    }
}
