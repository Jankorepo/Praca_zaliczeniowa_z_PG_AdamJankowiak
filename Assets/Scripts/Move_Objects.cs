﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Objects : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
