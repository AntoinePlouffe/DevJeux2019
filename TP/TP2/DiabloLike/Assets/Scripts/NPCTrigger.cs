using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    private bool DialogueSeen = false;
    private void OnTriggerEnter(Collider other)
    {
        if (DialogueSeen == false)
        {
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();
            DialogueSeen = true;
        }
     
    }
}
