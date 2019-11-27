using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public GameObject m_GameOverMenu;

    private void Start()
    {
        m_GameOverMenu.SetActive(false);
    }
}
