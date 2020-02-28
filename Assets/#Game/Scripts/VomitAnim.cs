﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VomitAnim : MonoBehaviour
{

    Material material = null;


    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        material.SetFloat("_DegOFfset", Mathf.Sin(Time.time * Mathf.PI * 2) * 360);
    }
}
