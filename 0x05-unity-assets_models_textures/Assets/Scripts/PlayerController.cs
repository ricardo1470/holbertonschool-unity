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
    // speed
    public float speed;

    // jump
    public float jump;

    // gravity Value
    private float gravityValue = 9.81f;

    private UnityEngine.CharacterController player;

    void Start ()
    {
        player = GetComponent<CharacterController> ();
    }

    void update ()
    {
    }


    void FixedUpdate()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(Horizontal, 0.0f, Vertical);
        player.Move(move * speed * Time.deltaTime);

        // value keyboard Space
        if (Input.GetKey(KeyCode.Space))
        {
            player.Move(new Vector3(0, gravityValue * jump * Time.deltaTime, 0));
        }
    }
}