using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Serialization;

public class PlayerController : MonoBehaviour
{
    // variables for x-axis and y-axis
    // x = horizontal
    private float Horizontal;

    // z = vertical
    private float Vertical;

    // player object assignment
    private CharacterController player;

    // speed
    public float speed;

    //direction the player is moving
    private Vector3 movePlayer;

    // camera
    public Camera mainCamera;

    //camera forward
    private Vector3 camForward;

    // camera to the right
    private Vector3 camRight;

    // gravity
    private float gravity = 9.8f;

    // falling speed
    public float fallVelocity;

    // jump
    public float jumpForce;

    public void Start ()
    {
        player = GetComponent<CharacterController> ();
    }

    public void update ()
    {
    }

    public void FixedUpdate()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        //camera directtion
        camDirection();

        movePlayer = ((Horizontal * camRight) + (Vertical * camForward));

        movePlayer = movePlayer * speed;

        player.transform.LookAt(player.transform.position + movePlayer);

        // function for gravity
        SetGravity();

        // functions
        playerSkills();

        if (transform.position.y > -20)
        {
            player.Move(movePlayer * Time.deltaTime);
        }
        else
        {
            //gravity = 9.8f;
            transform.position = new Vector3(0, 10, 0);
        }
    }

    // function for the camera
    public void camDirection()
    {
        // forward direction of main camera
        camForward = mainCamera.transform.forward;
        //direction to the right of the main camera
        camRight = mainCamera.transform.right;

        // y axis set to 0
        camForward.y = 0;
        // right relative to y axis set to 0
        camRight.y = 0;

        // Adjusted vector direction
        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }

    // function Skills
    public void playerSkills()
    {
        if (Input.GetButtonDown("Jump") && player.isGrounded)
        {
            fallVelocity = jumpForce;
            movePlayer.y = fallVelocity;
        }

    }

    // function for gravity
    public void SetGravity()
    {
        if (player.isGrounded)
        {
            fallVelocity = -gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
        else
        {
            fallVelocity -= gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
    }
}
