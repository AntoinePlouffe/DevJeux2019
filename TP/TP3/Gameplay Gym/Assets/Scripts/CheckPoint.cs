using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameplayManager m_GameplayManager;

    private void OnTriggerEnter(Collider other)
    {
        m_GameplayManager.SetLastCheckPoint(transform.position);
    }
}
