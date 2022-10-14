using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigeonController : MonoBehaviour
{

    public float speed = 15.0f;
    public float turnSpeed = 200.0f;
    public float horizontalInput;
    
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed );

        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
    }
}
