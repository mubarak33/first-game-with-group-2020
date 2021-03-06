﻿using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
               print ("one step");
                transform.Rotate(0, -transform.rotation.x + 90, 0);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Rotate(0,transform.rotation.x-90, 0);
            }
        

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

  
}