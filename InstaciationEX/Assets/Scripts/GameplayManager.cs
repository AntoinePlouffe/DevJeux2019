using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public GameObject m_ObjectToSpawn;

    void Start()
    {
        GameObject.Instantiate(m_ObjectToSpawn, Vector3.zero, Quaternion.identity); //fait apparaitre un gameObject
    }

}
