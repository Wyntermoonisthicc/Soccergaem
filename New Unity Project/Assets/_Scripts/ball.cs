using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody rb;
    public float ballthrust;
    public Vector3 vec3;



    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * ballthrust, ForceMode.Force);

        
    }

   
}

