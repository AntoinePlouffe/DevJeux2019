using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject text;

    private void Start()
    {
        text.gameObject.SetActive(false);
    }

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        text.gameObject.SetActive(true);

    }



}
