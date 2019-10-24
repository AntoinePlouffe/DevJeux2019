using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleCoroutine : MonoBehaviour
{


    void Start()
    {
        TestFonction(); //call the fonction TestFonction
        StartCoroutine("TestCoroutine"); //call the coroutine TestCoroutine
    }

    void TestFonction() //take one second to execute all the fonction
    {
        Debug.Log("ma fonction");

        for (int i = 0; i < 250; i++)
        {
            Debug.Log("fonction for");
        }

        Debug.Log("frame 101 fonction");
    }

    IEnumerator TestCoroutine() //a coroutine create a pause
    {
        Debug.Log("mon premier log de coroutine");

        yield return new WaitForSeconds(5f); //create a pause of 5 second

        Debug.Log("frame 1");

        for (int i = 0; i < 250; i++)
        {
            yield return null; //create a pause for one frame
        }

        Debug.Log("frame 101");

        yield return null;
    }
}
