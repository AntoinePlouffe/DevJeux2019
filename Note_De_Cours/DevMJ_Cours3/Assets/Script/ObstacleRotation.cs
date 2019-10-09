using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mRotation = new Vector3();
        mRotation.y = mRotation.y + 1f;
        transform.Rotate(mRotation);
    }
}
