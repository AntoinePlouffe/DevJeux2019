using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    //Variables
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        /*Vector3.up * -1f*/ //newVector3 (0f, -1f, 0f)
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, new Vector3(0f, -0.5f, 0f), Color.red);

        if (Physics.Raycast(transform.position, new Vector3(0f, -1f, 0f), out hit, 0.5f))
        {
            Debug.Log("j'ai toucher un objet");
        }
        else
        {
            Debug.Log("Nope");
        }
    }
}
