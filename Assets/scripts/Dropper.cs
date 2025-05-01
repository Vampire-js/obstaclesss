using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer meshRenderer;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        rb.useGravity = false;
        meshRenderer.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 5){
        rb.useGravity = true;
        meshRenderer.enabled = true;  
        } 
    }
}
