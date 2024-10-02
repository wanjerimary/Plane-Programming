using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    public float speed = 1.0f;         // speed of the plane
    public float tiltAngle = 10.0f;    // tilt angle
    public Transform cameraTransform;  //
    public float spinSpeed = 300.0f;         //  propeller  spin speed                    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Move plane backwards
        
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        

        // Check user input for tilt
        
            float tiltInput = Input.GetAxis("Vertical");  //Up/Down arrowkeys
            if (tiltInput != 0)
               
            {
                // Calculate tilt angle
                float tilt = tiltInput * tiltAngle;

                // Aplying tilt input
               

            }

        // Camera behind the plane
            if (cameraTransform != null)
            {
                cameraTransform.position = cameraTransform.position + new Vector3(0, 0, 180);
                cameraTransform.LookAt(cameraTransform.position);
            }

        //camera position to follow plane
            {
                Vector3 cameraOffset = new Vector3(0, 1, 3);
                cameraTransform.position = cameraTransform.position + cameraOffset;
                cameraTransform.LookAt(cameraTransform.position);
            }
        // set propeller to rotate as set speed
            {
                transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
            }

        

    }

    


}
