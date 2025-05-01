using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Renderer renderer = GetComponent<Renderer>();
     

        if(collision.gameObject.tag == "Player"){
        renderer.material.color = Color.red; 
        gameObject.tag = "Hit";
        Debug.Log("Hit " + collision.gameObject.tag);
        }
    }
}
