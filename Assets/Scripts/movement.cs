using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController controller;  
    public float WalkingSpeed = 10f;
    public float GRAVITATIONAL_ACCELERATION = -9.18f;
    public float fallSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if(controller.isGrounded){
            fallSpeed = 0f;
        }
        else{
            fallSpeed += GRAVITATIONAL_ACCELERATION * Time.deltaTime;
        }
        Vector3 move = transform.right * x * WalkingSpeed + transform.forward * z * WalkingSpeed
                       + transform.up * fallSpeed ;
        controller.Move(move*Time.deltaTime);

    }
}
