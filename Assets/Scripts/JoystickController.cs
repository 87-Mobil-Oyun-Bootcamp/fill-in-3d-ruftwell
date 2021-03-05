using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoystickController : MonoBehaviour
{
    float vertical, horizontal;
    public int speed;
    public Rigidbody rb;

    public Joystick joystick;
    
    void FixedUpdate()
    {
        Movement();
    }


    void Movement()
    {
        vertical = joystick.Vertical;
        horizontal = joystick.Horizontal;

        if (vertical != 0 || horizontal != 0)
        {
            transform.forward = new Vector3(horizontal * speed, 0, vertical * speed);
            //transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime, Space.World);
            rb.velocity = new Vector3(-vertical * speed, 0, horizontal * speed);
        }
    }
}
