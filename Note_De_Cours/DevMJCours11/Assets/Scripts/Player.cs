using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down * 1000f, Color.blue);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1000f, LayerMask.GetMask("Floor", "lavaFloor")))
        {
            Debug.Log(hit.collider.gameObject.tag);
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision");

        Debug.Log(collision.gameObject.name);
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.tag == "Lava")
        {
            ///Mon player die
        }

        if (collision.gameObject.tag == "Ground")
        {
            //mon player peut sauter
        }
    }

}
