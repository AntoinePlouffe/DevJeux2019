﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; //Player

    public Vector3 offset;

    void Start()
    {
        
    }


    void Update()
    {
        transform.position = target.position + offset;
    }
}