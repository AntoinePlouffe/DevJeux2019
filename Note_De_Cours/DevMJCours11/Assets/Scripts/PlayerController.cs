using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 move = new Vector3();
    float x = 0f;
    float y = 0f;
    float z = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //move.x = -5f;
            //x = -5f;

            x -= 0.01f; //Augmente par tic la valeur de -x

            if (x <= -3f) //Limite la vitesse du cube en -x
            {
                x = -3f;
            }
        }

        else if (Input.GetKey(KeyCode.D))
        {
            //move.x = 5f;
            //x = 5f;

            x += 0.01f; //Augmente par tic la valeur de x

            if (x >= 3f) //Limite la vitesse du cube en x
            {
                x = 3f;
            }
        }

        else
        {
            //move.x = 0f;
            //x = 0f;

            x *= 0.9f; //Ralenti le cube lorsqu'il n'a plus de mouvement

            if (x >= -0.1 && x <= 0.1f) //permet au cube de s'arreter completement
            {
                x = 0f;
            }
        }

        //transform.Translate(move);
        transform.Translate(x, y, z);

        Debug.Log(x); //Affiche la valeur x dans la console
    }
}
