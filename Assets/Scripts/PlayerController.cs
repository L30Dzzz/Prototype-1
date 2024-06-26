using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    public Camera mainCamera;
    public Camera sideCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // moves car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // rotates car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (mainCamera.enabled == true)
            {
            // changes view to side cam
            mainCamera.enabled = false;
            sideCamera.enabled = true;
            }
        

        else if (sideCamera.enabled == true) 
        
            {
            // changes view to main cam
            mainCamera.enabled = true;
            sideCamera.enabled = false;
            }
        }
    }
}
