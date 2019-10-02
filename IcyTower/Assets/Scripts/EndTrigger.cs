using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject text;
    public GameObject text2;

    private void Start()
    {
        text.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
    }

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        text.gameObject.SetActive(true);
        text2.gameObject.SetActive(true);


    }



}
