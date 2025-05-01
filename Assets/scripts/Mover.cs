using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{


    public float xValue = 0.1f;
    public float yValue = 0f;
    public float zValue = 0f;

    public float speed = 10f;  
    void Start()
    {
       
    }

    void Update()
    {
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        zValue = Input.GetAxis("Vertical")* Time.deltaTime * speed;
        transform.Translate(xValue, yValue, zValue);

         }
}
