using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    bool nextLevel = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            nextLevel = true;
        }
    }

    private void Update()
    {
        if (nextLevel == true)
        {

            if (Input.anyKey)
            {
                SceneManager.LoadScene("Level2");
            }
        }
    }
}
