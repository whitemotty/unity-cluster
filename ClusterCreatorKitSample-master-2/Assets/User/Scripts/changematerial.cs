﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changematerial : MonoBehaviour
{

    public GameObject data;
    public TextMesh tex;

    private double mol = 5;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("Hit");

        mol *= 0.5;
        tex.text = "元素 : NaCL\n濃度: " + mol + " %";
    }
}
