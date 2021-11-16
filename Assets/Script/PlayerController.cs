using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25f;
    private float turnSpeed = 10.0f;
    private float horizontalInput;
    private float verticalInput;
    private float advanceSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        horizontalInput = Input.GetAxis("Horizontal");  // Tomamos eje horizontal del Input Manager
       
        verticalInput = Input.GetAxis("Vertical");  // Tomamos eje vertical del Input Manager

        
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput); // Movimiento hacia adelante

        
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput); // Movimiento lateral

        
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput); // Rotación


    }
}
