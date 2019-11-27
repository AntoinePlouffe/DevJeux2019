using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject m_WinMenu;

    public void Start()
    {
        m_WinMenu.SetActive(false); //Desactive le gameObject
    }

    //Quand il a une collision
    private void OnTriggerEnter(Collider other)
    {
        //Quand il a une collision avec le joueur
        if (other.gameObject.tag == "Player")
        {
            m_WinMenu.SetActive(true); //Active le gameObject
        }
    }
}
