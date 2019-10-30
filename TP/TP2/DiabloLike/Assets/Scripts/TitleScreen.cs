using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public GameObject m_PlayContainer;
    public GameObject m_QuitContainer;

    public void LoadGamePlay()
    {
        SceneManager.LoadScene("Donjon"); //Change de scene pour Donjon
    }

    public void QuitGame()
    {
        EditorApplication.isPlaying = false; //Quitte du PlayMode
    }
}
