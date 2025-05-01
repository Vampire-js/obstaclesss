using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float xValue = 0.1f;
    public float yValue = 0f;
    public float zValue = 0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * 10f;
        zValue = Input.GetAxis("Vertical")* Time.deltaTime * 10f;
        transform.Translate(xValue, yValue, zValue);
    }
}
