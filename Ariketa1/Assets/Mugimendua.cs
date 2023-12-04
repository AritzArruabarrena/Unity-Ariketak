using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mugimendua : MonoBehaviour
{
    public float speed = 5f;
    public string direction;
    public Vector3 movement;
    public Boolean giratzendago = false;
    public float giratu;


    // Start is called before the first frame update
    void Start()
    {
        // Define the initial position
        transform.position = Vector3.zero;
        direction = "Forward";
        movement = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        var angles = transform.rotation.eulerAngles;
        if (!giratzendago) { 
        // Move the object
        transform.position += movement * speed * Time.deltaTime;
            // Define the movement depending on each direction
        if (direction.Equals("Forward") && transform.position.z >= 10)
        {
            //transform.rotation = Quaternion.Euler(0, 90, 0);
            direction = "Right";
            movement = Vector3.right;
            giratzendago=true;
        }
        else if (direction.Equals("Right") && transform.position.x >= 10)
        {
            //transform.rotation = Quaternion.Euler(0, 180, 0);
            direction = "Back";
            movement = Vector3.back;
            giratzendago=true;
        }
        else if (direction.Equals("Back") && transform.position.z <= 0)
        {
            //transform.rotation = Quaternion.Euler(0, 270, 0);
            direction = "Left";
            movement = Vector3.left;
            giratzendago=true;
        }
        else if (direction.Equals("Left") && transform.position.x <= 0)
        {
            //transform.rotation = Quaternion.Euler(0, 0, 0);
            direction = "Forward";
            movement = Vector3.forward;
            giratzendago=true;
        }
        } else {
            if (angles.y <= 90)
            {
                angles.y += speed * Time.deltaTime * 10;
                transform.rotation = Quaternion.Euler(angles);
            }
            else
            {
                giratzendago = false;
            }
        }
    }
}


