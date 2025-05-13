using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlyerMovementJoystick : MonoBehaviour {

    public Joystick joystick;
    public Joybutton joybutton;

    
    public float vx = 30f;
    public float vy = 30f;
    public float Vjump = 15f;

    // public Rigidbody rb;

    protected bool jump;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();

    }

    void Update()
    {
        var rigitbody = GetComponent<Rigidbody>();

        rigitbody.velocity = new Vector3(joystick.Horizontal * vx, rigitbody.velocity.y, joystick.Vertical * vy);
               

        if (!jump && joybutton.Pressed)
        {

            jump = true;
            rigitbody.velocity += Vector3.up * Vjump;

        }

        if (jump && !joybutton.Pressed)

        {

            jump = false;

        }

    }

    

}
