using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject m_DialogueMenu;

    public Text NameText;
    public Text DialogueText;

    private Queue<string> sentences;

    void Start()
    {
        m_DialogueMenu.SetActive(false);

        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        FindObjectOfType<Player>().m_CanHeMove = false;

        m_DialogueMenu.SetActive(true);

        NameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        DialogueText.text = sentence;
    }

    void EndDialogue()
    {
        FindObjectOfType<Player>().m_CanHeMove = true;

        m_DialogueMenu.SetActive(false);

        Debug.Log("End of conversation");
    }
}
